Imports System.IO

Public Class frm_main
    Dim ini As New ini_file

    Private Sub frm_main_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ini.WriteValue("path", "u_source", tb_path.Text.ToString)
        ini.WriteValue("path", "u_name", tb_name.Text.ToString)
        ini.WriteValue("versioning", "scheme", rBtn_ver_normal.Checked)
        ini.WriteValue("versioning", "build", numupdown_build.Value.ToString)
    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_path.Text = ini.ReadValue("path", "u_source", "Not Set")
        tb_name.Text = ini.ReadValue("path", "u_name", "Not Set")
        numupdown_build.Value = CInt(ini.ReadValue("versioning", "build", "0"))

        If CBool(ini.ReadValue("versioning", "scheme", "True")) Then
            rBtn_ver_normal.Checked = True
        Else
            rBtn_ver_tesla.Checked = True
        End If

        pnl_working.Hide()
        pnl_finished.Hide()
    End Sub

    Dim build_week As String = DatePart(DateInterval.WeekOfYear, Date.Today, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFourDays)
    Private Sub btn_make_updatePack_Click(sender As Object, e As EventArgs) Handles btn_make_updatePack.Click
        pnl_working.Show()
        Me.Refresh()

        Dim u_pack_name As String 'working dir
        If rBtn_ver_normal.Checked = True Then
            u_pack_name = tb_name.Text & "_" & DateTime.Now.Year.ToString("00").Remove(0, 2) & DateTime.Now.Month.ToString("00") & DateTime.Now.Day.ToString("00") & "_" & DateTime.Now.Hour.ToString("00") & DateTime.Now.Minute.ToString("00")
        Else
            If numupdown_build.Value = 0 Then
                u_pack_name = tb_name.Text & "_" & DateTime.Now.Year.ToString() & "." & build_week
            Else
                u_pack_name = tb_name.Text & "_" & DateTime.Now.Year.ToString() & "." & build_week & "_U" & numupdown_build.Value.ToString
            End If
        End If

        Dim u_pack_path As String = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\vs_update_packages\" & u_pack_name)

        lbl_task.Text = "Create working folder..."
        prog(5)
        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\vs_update_packages") Then
            IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\vs_update_packages")
        End If

        lbl_task.Text = "Create update sub-folder..."
        prog(10)
        If Not IO.Directory.Exists(u_pack_path) Then
            IO.Directory.CreateDirectory(u_pack_path)
        End If

        lbl_task.Text = "Copying app-files to update folder..."
        prog(40)
        DirectoryCopy(tb_path.Text, u_pack_path)

        lbl_task.Text = "Generating version infos..."
        prog(45)
        ini.write_versionfile("BUILD", "version", u_pack_name.Replace(tb_name.Text & "_", ""), u_pack_path & "\build_info")
        ini.write_versionfile("BUILD", "date", DateTime.Now.ToShortDateString & "_" & DateTime.Now.ToLongTimeString, u_pack_path & "\build_info")

        lbl_task.Text = "Cleanup app-files..."
        prog(60)
        del_files(u_pack_path)

        lbl_task.Text = "Create update package (ZIP), this may take some time..."
        prog(65)
        Shell("7za a -tzip " & u_pack_name & ".zip " & u_pack_path & "\" & " -mx9 -mmt", AppWinStyle.Hide, True)

        lbl_task.Text = "Check if file already exists..."
        prog(85)
        If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & u_pack_name & ".zip") Then
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & u_pack_name & ".zip")
        End If

        lbl_task.Text = "Copying update package to Desktop"
        prog(90)
        IO.File.Move((Application.StartupPath & "\" & u_pack_name & ".zip"), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & u_pack_name & ".zip")

        lbl_task.Text = "Cleanup working folder..."
        prog(100)
        Directory.Delete(u_pack_path, True)
        Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\vs_update_packages", True)

        Threading.Thread.Sleep(500)
        lbl_task.Text = ""
        pnl_working.Hide()
        pnl_finished.Show()
        Me.Refresh()
        tmr_finished.Start()
    End Sub

    Private Shared Sub DirectoryCopy(ByVal sourceDirName As String, ByVal destDirName As String)
        ' Get the subdirectories for the specified directory.
        Dim dir As DirectoryInfo = New DirectoryInfo(sourceDirName)

        If Not dir.Exists Then
            Throw New DirectoryNotFoundException(
                "Source directory does not exist or could not be found: " _
                + sourceDirName)
        End If

        Dim dirs As DirectoryInfo() = dir.GetDirectories()
        ' If the destination directory doesn't exist, create it.
        If Not Directory.Exists(destDirName) Then
            Directory.CreateDirectory(destDirName)
        Else
            Directory.Delete(destDirName, True)
            Directory.CreateDirectory(destDirName)
        End If
        ' Get the files in the directory and copy them to the new location.
        Dim files As FileInfo() = dir.GetFiles()
        For Each file In files
            Dim temppath As String = Path.Combine(destDirName, file.Name)
            file.CopyTo(temppath, False)
        Next file

        ' If copying subdirectories, copy them and their contents to new location.
        For Each subdir In dirs
            Dim temppath As String = Path.Combine(destDirName, subdir.Name)
            DirectoryCopy(subdir.FullName, temppath)
        Next subdir
    End Sub

    Private Sub del_files(ByVal dirName As String)
        If IO.File.Exists(dirName & "\MahApps.Metro.pdb") Then IO.File.Delete(dirName & "\MahApps.Metro.pdb")

        If IO.File.Exists(dirName & "\MahApps.Metro.xml") Then IO.File.Delete(dirName & "\MahApps.Metro.xml")

        If IO.File.Exists(dirName & "\Newtonsoft.Json.xml") Then IO.File.Delete(dirName & "\Newtonsoft.Json.xml")

        If IO.File.Exists(dirName & "\SmartUI.pdb") Then IO.File.Delete(dirName & "\SmartUI.pdb")

        If IO.File.Exists(dirName & "\SmartUI.vshost.exe") Then IO.File.Delete(dirName & "\SmartUI.vshost.exe")

        If IO.File.Exists(dirName & "\SmartUI.vshost.exe.config") Then IO.File.Delete(dirName & "\SmartUI.vshost.exe.config")

        If IO.File.Exists(dirName & "\SmartUI.xml") Then IO.File.Delete(dirName & "\SmartUI.xml")

        If IO.File.Exists(dirName & "\SmartUI.vshost.exe.manifest") Then IO.File.Delete(dirName & "\SmartUI.vshost.exe.manifest")

        If Directory.Exists(dirName & "\.vs") Then Directory.Delete(dirName & "\.vs", True)

        If IO.Directory.Exists(dirName & "\config") Then Directory.Delete(dirName & "\config", True)

        If IO.Directory.Exists(dirName & "\cache") Then Directory.Delete(dirName & "\cache", True)
    End Sub

    Private Sub prog(e As Integer)
        lbl_progress.Text = e & "%"
        lbl_progress.Width = e * 4.15
        Me.Refresh()
        Threading.Thread.Sleep(100)
    End Sub

    Private Sub tb_name_TextChanged(sender As Object, e As EventArgs) Handles tb_name.TextChanged, rBtn_ver_normal.CheckedChanged, numupdown_build.ValueChanged
        If rBtn_ver_normal.Checked = True Then
            numupdown_build.Enabled = False
            lbl_packagename.Text = "ZIP-Name: " & tb_name.Text & "_" & DateTime.Now.Year.ToString("00").Remove(0, 2) & DateTime.Now.Month.ToString("00") & DateTime.Now.Day.ToString("00") & "_" & DateTime.Now.Hour.ToString("00") & DateTime.Now.Minute.ToString("00")
        Else
            numupdown_build.Enabled = True
            If numupdown_build.Value = 0 Then
                lbl_packagename.Text = "ZIP-Name: " & tb_name.Text & "_" & DateTime.Now.Year & "." & build_week & ".zip"
            Else
                lbl_packagename.Text = "ZIP-Name: " & tb_name.Text & "_" & DateTime.Now.Year & "." & build_week & "_U" & numupdown_build.Value.ToString & ".zip"
            End If
        End If
    End Sub

    Private Sub tmr_finished_Tick(sender As Object, e As EventArgs) Handles tmr_finished.Tick
        pnl_finished.Hide()
        tmr_finished.Stop()
    End Sub
End Class

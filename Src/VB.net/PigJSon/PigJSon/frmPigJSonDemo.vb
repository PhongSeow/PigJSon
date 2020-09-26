﻿Public Class frmPigJSonDemo
    Private pjAssemble As PigJSon
    Private pjParse As PigJSon
    Private strJSonKey As String

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub ParseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ParseToolStripMenuItem1.Click
        If Len(Me.tbMain.Text) = 0 Then
            MsgBox("Please enter the JSON string in the text box", MsgBoxStyle.Exclamation, sender.ToString)
        Else
            pjParse = New PigJSon(Me.tbMain.Text)
            If pjParse.LastErr <> "" Then
                MsgBox(pjParse.LastErr, MsgBoxStyle.Critical, sender.ToString)
            Else
                MsgBox("Parse success", MsgBoxStyle.Information, sender.ToString)
            End If
        End If
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        frmAbout.ShowDialog()
    End Sub


    Private Sub SeowPhongHomePageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeowPhongHomePageToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://en.seowphong.com/")
    End Sub

    'Private Sub ArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrayToolStripMenuItem.Click
    '    Dim pjSites As New PigJSon, pjOneSite As New PigJSon, pjSiteInf As New PigJSon, pjFull As New PigJSon
    '    Dim strRet As String
    '    Dim strDisplay As String = ""
    '    strDisplay &= "***Sample code***" & vbCrLf
    '    strDisplay &= "pjAssemble = New PigJSon" & vbCrLf
    '    strDisplay &= "With pjAssemble" & vbCrLf
    '    strDisplay &= vbTab & ".AddEle(""SiteName"", ""Seow Phong Web Site"", True)    'The first element needs to be explicitly specified" & vbCrLf
    '    strDisplay &= vbTab & ".AddEle(""SiteUrl"", ""http://www.seowphong.com"")  'The default is not the first element" & vbCrLf
    '    strDisplay &= vbTab & ".AddEle(""Describe"", ""A website for free software"" & vbCrLf & "" and shareware"") 'The text contains a carriage return" & vbCrLf
    '    strDisplay &= vbTab & ".AddEle(""Rank"", 168)" & vbCrLf
    '    strDisplay &= vbTab & ".AddEle(""VisitPerDay"", CDec(168.88))" & vbCrLf
    '    strDisplay &= vbTab & ".AddEle(""VisitTimeStr"", ""8/8/2020"")" & vbCrLf
    '    strDisplay &= vbTab & ".AddEle(""VisitTime"", Now)" & vbCrLf
    '    strDisplay &= vbTab & ".AddEle(""VisitTimeGT"", Now, False, False)   'Global time" & vbCrLf
    '    strDisplay &= vbTab & ".AddSymbol(PigJSon.xpSymbolType.EleEndFlag)" & vbCrLf
    '    strDisplay &= "End With" & vbCrLf

    '    With pjSites
    '        .Init()
    '        '-------------
    '        With pjOneSite
    '            .Init()
    '            .AddEle("SiteName", "Google", True)
    '            '不指定 EleKey 则各元素按照数组元素排列。



    '            With pjSiteInf
    '                .Init()
    '                .AddEle("", "Android", True)
    '                .AddEle("", "Google search")
    '                .AddEle("", "Google Maps")
    '            End With
    '            .AddArrayEle("SiteInfo", pjSiteInf.MainJSonStr, True)
    '            .AddSymbol(PigJSon.xpSymbolType.ArrayEndFlag)
    '            .AddSymbol(PigJSon.xpSymbolType.EleEndFlag)
    '        End With
    '        .AddEle("", pjOneSite.MainJSonStr, True)
    '        '-------------
    '        With pjOneSite
    '            .Init()
    '            .AddEle("SiteName", "Amazon", True)
    '            With pjSiteInf
    '                .Init()
    '                .AddEle("", "Robot Check", True)
    '                .AddEle("", "AWS")
    '            End With
    '            .AddArrayEle("SiteInfo", pjSiteInf.MainJSonStr)
    '        End With
    '        .AddEle("", pjOneSite.MainJSonStr, True)
    '        '-------------
    '        With pjOneSite
    '            .Init()
    '            .AddEle("SiteName", "Microsoft", True)
    '            With pjSiteInf
    '                .Init()
    '                .AddEle("", "Microsoft Windows", True)
    '                .AddEle("", "Azure")
    '                .AddEle("", "Microsoft Office", True)
    '            End With
    '            .AddArrayEle("SiteInfo", pjSiteInf.MainJSonStr)
    '        End With
    '        .AddEle("", pjOneSite.MainJSonStr, True)
    '        '-------------
    '    End With

    '    With pjFull
    '        .Init()
    '        .AddEle("SiteInf", "Website introduction")
    '        .AddEle("TotalSites", 3)
    '        .AddArrayEle("Sites", pjSites.MainJSonStr)
    '    End With
    '    With pjAssemble
    '        .AddEle("SiteName", "Seow Phong Web Site", True)
    '        .AddEle("SiteUrl", "http://www.seowphong.com")
    '        .AddEle("Describe", "A website for free software" & vbCrLf & " and shareware")
    '        .AddEle("Rank", 168)
    '        .AddEle("VisitPerDay", CDec(168.88))
    '        .AddEle("VisitTimeStr", "8/8/2020")
    '        .AddEle("VisitTime", Now)
    '        .AddEle("VisitTimeGT", Now, False, False)   'Global time
    '        .AddSymbol(PigJSon.xpSymbolType.EleEndFlag)
    '        strRet = .ParseJSON()
    '        strDisplay &= "***Return results***" & vbCrLf
    '        strDisplay &= "MainJSonStr=" & .MainJSonStr & vbCrLf
    '        strDisplay &= "ParseJSON=" & strRet & vbCrLf
    '        If strRet = "OK" Then
    '            strDisplay &= "With pjAssemble" & vbCrLf
    '            strDisplay &= vbTab & ".GetStrValue(""SiteName"")=" & .GetStrValue("SiteName") & vbCrLf
    '            strDisplay &= vbTab & ".GetStrValue(""SiteUrl"")=" & .GetStrValue("SiteUrl") & vbCrLf
    '            strDisplay &= vbTab & ".GetIntValue(""Rank"")=" & .GetIntValue("Rank").ToString & vbCrLf
    '            strDisplay &= vbTab & ".GetDecValue(""VisitPerDay"")=" & .GetDecValue("VisitPerDay").ToString & vbCrLf
    '            strDisplay &= vbTab & ".GetStrValue(""VisitTimeStr"")=" & .GetStrValue("VisitTimeStr").ToString & vbCrLf
    '            strDisplay &= vbTab & ".GetDateValue(""VisitTime"")=" & .GetDateValue("VisitTime").ToString & vbCrLf
    '            strDisplay &= vbTab & ".GetDateValue(""VisitTimeGT"", False)=" & .GetDateValue("VisitTimeGT", False).ToString & vbCrLf
    '            strDisplay &= "End With" & vbCrLf
    '        End If
    '    End With
    '    Me.tbMain.Text = strDisplay
    'End Sub

    Private Sub PiggyJSonPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PiggyJSonPageToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://en.seowphong.com/oss/pigjson/")
    End Sub

    Private Sub ShowJSonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowJSonToolStripMenuItem.Click
        strJSonKey = InputBox("JSonKey=", sender.ToString, strJSonKey)
        Me.tbMain.Text &= strJSonKey & "=" & pjParse.GetStrValue(strJSonKey) & vbCrLf
        If pjParse.LastErr <> "" Then Me.tbMain.Text &= strJSonKey & " error = " & pjParse.LastErr & vbCrLf
    End Sub

    Private Sub SimpleElementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpleElementsToolStripMenuItem.Click
        Dim strRet As String
        Dim strDisplay As String = ""
        strDisplay &= "***" & sender.ToString & " Sample code***" & vbCrLf
        strDisplay &= "pjAssemble = New PigJSon" & vbCrLf
        strDisplay &= "With pjAssemble" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""SiteName"", ""Seow Phong Web Site"", True)    'The first element needs to be explicitly specified" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""SiteUrl"", ""http://www.seowphong.com"")  'The default is not the first element" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""Describe"", ""A website for free software"" & vbCrLf & "" and shareware"") 'The text contains a carriage return" & vbCrLf
        strDisplay &= vbTab & ".AddSymbol(PigJSon.xpSymbolType.EleEndFlag)" & vbCrLf
        strDisplay &= vbTab & ".ParseJSON()" & vbCrLf
        strDisplay &= vbTab & "Debug.Print(.MainJSonStr)" & vbCrLf
        strDisplay &= vbTab & "Debug.Print(.GetStrValue(""SiteName""))" & vbCrLf
        strDisplay &= vbTab & "Debug.Print(.GetStrValue(""SiteUrl""))" & vbCrLf
        strDisplay &= vbTab & "Debug.Print(.GetStrValue(""Describe""))" & vbCrLf
        strDisplay &= "End With" & vbCrLf

        pjAssemble = New PigJSon
        With pjAssemble
            .AddEle("SiteName", "Seow Phong Web Site", True)    'The first element needs to be explicitly specified
            .AddEle("SiteUrl", "http://www.seowphong.com")  'The default is not the first element
            .AddEle("Describe", "A website for free software" & vbCrLf & " and shareware")  'The text contains a carriage return
            .AddSymbol(PigJSon.xpSymbolType.EleEndFlag)
            strRet = .ParseJSON()
            If strRet = "OK" Then
                strDisplay &= "***Return results***" & vbCrLf
                strDisplay &= .MainJSonStr & vbCrLf
                strDisplay &= .GetStrValue("SiteName") & vbCrLf
                strDisplay &= .GetStrValue("SiteUrl") & vbCrLf
                strDisplay &= .GetStrValue("Describe") & vbCrLf
            End If
        End With
        Me.tbMain.Text = strDisplay
    End Sub

    Private Sub SimpleTextElementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpleTextElementsToolStripMenuItem.Click
        Dim strRet As String
        Dim strDisplay As String = ""
        strDisplay &= "***Sample code***" & vbCrLf
        strDisplay &= "pjAssemble = New PigJSon" & vbCrLf
        strDisplay &= "With pjAssemble" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""SiteName"", ""Seow Phong Web Site"", True)    'The first element needs to be explicitly specified" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""SiteUrl"", ""http://www.seowphong.com"")  'The default is not the first element" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""Describe"", ""A website for free software"" & vbCrLf & "" and shareware"") 'The text contains a carriage return" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""Rank"", 168)" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""VisitPerDay"", CDec(168.88))" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""VisitTimeStr"", ""8/8/2020"")" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""VisitTime"", Now)" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""VisitTimeGT"", Now, False, False)   'Global time" & vbCrLf
        strDisplay &= vbTab & ".AddSymbol(PigJSon.xpSymbolType.EleEndFlag)" & vbCrLf
        strDisplay &= "End With" & vbCrLf

        pjAssemble = New PigJSon
        With pjAssemble
            .AddEle("SiteName", "Seow Phong Web Site", True)    'The first element needs to be explicitly specified
            .AddEle("SiteUrl", "http://www.seowphong.com")  'The default is not the first element
            .AddEle("Describe", "A website for free software" & vbCrLf & " and shareware")  'The text contains a carriage return
            .AddEle("Rank", 168)
            .AddEle("VisitPerDay", CDec(168.88))
            .AddEle("VisitTimeStr", "8/8/2020")
            .AddEle("VisitTime", Now)
            .AddEle("VisitTimeGT", Now, False, False)   'Global time
            .AddSymbol(PigJSon.xpSymbolType.EleEndFlag)
            strRet = .ParseJSON()
            strDisplay &= "***Return results***" & vbCrLf
            strDisplay &= "MainJSonStr=" & .MainJSonStr & vbCrLf
            strDisplay &= "ParseJSON=" & strRet & vbCrLf
            If strRet = "OK" Then
                strDisplay &= "With pjAssemble" & vbCrLf
                strDisplay &= vbTab & ".GetStrValue(""SiteName"")=" & .GetStrValue("SiteName") & vbCrLf
                strDisplay &= vbTab & ".GetStrValue(""SiteUrl"")=" & .GetStrValue("SiteUrl") & vbCrLf
                strDisplay &= vbTab & ".GetStrValue(""Describe"")=" & .GetStrValue("Describe") & vbCrLf
                strDisplay &= vbTab & ".GetIntValue(""Rank"")=" & .GetIntValue("Rank").ToString & vbCrLf
                strDisplay &= vbTab & ".GetDecValue(""VisitPerDay"")=" & .GetDecValue("VisitPerDay").ToString & vbCrLf
                strDisplay &= vbTab & ".GetStrValue(""VisitTimeStr"")=" & .GetStrValue("VisitTimeStr") & vbCrLf
                strDisplay &= vbTab & ".GetDateValue(""VisitTime"")=" & .GetDateValue("VisitTime").ToString & vbCrLf
                strDisplay &= vbTab & ".GetDateValue(""VisitTimeGT"", False)=" & .GetDateValue("VisitTimeGT", False).ToString & vbCrLf
                strDisplay &= "End With" & vbCrLf
            End If
        End With
        Me.tbMain.Text = strDisplay
    End Sub

    Private Sub SimpleArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpleArrayToolStripMenuItem.Click
        Dim strRet As String
        Dim strDisplay As String = ""
        strDisplay &= "***Sample code***" & vbCrLf
        strDisplay &= "pjArray = New PigJSon" & vbCrLf
        strDisplay &= "With pjArray" & vbCrLf
        strDisplay &= vbTab & ".AddEle("""", ""Google"", True)" & vbCrLf
        strDisplay &= vbTab & ".AddEle("""", ""GitHub"")" & vbCrLf
        strDisplay &= vbTab & ".AddEle("""", ""Apache"")" & vbCrLf
        strDisplay &= "End With" & vbCrLf
        strDisplay &= "pjAssemble = New PigJSon" & vbCrLf
        strDisplay &= "With pjAssemble" & vbCrLf
        strDisplay &= vbTab & ".AddOneArrayEle(""Sites"", pjArray.MainJSonStr, True)" & vbCrLf
        strDisplay &= vbTab & ".AddSymbol(PigJSon.xpSymbolType.EleEndFlag)" & vbCrLf
        strDisplay &= "End With" & vbCrLf
        Dim pjArray As PigJSon
        pjArray = New PigJSon
        With pjArray
            .AddEle("", "Google", True)
            .AddEle("", "GitHub")
            .AddEle("", "Apache")
        End With
        pjAssemble = New PigJSon
        With pjAssemble
            .AddOneArrayEle("Sites", pjArray.MainJSonStr, True)
            .AddSymbol(PigJSon.xpSymbolType.EleEndFlag)
            strRet = .ParseJSON()
            strDisplay &= "***Return results***" & vbCrLf
            strDisplay &= "MainJSonStr=" & .MainJSonStr & vbCrLf
            strDisplay &= "ParseJSON=" & strRet & vbCrLf
            If strRet = "OK" Then
                strDisplay &= "With pjAssemble" & vbCrLf
                strDisplay &= vbTab & ".GetStrValue(""Sites[0]"")=" & .GetStrValue("Sites[0]") & vbCrLf
                strDisplay &= vbTab & ".GetStrValue(""Sites[1]"")=" & .GetStrValue("Sites[1]") & vbCrLf
                strDisplay &= vbTab & ".GetStrValue(""Sites[2]"")=" & .GetStrValue("Sites[2]") & vbCrLf
                strDisplay &= "End With" & vbCrLf
            End If
        End With
        Me.tbMain.Text = strDisplay
    End Sub
End Class

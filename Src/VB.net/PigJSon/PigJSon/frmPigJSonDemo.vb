Public Class frmPigJSonDemo
    Private pjAssemble As PigJSon
    Private pjParse As PigJSon
    Private strJSonKey As String

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub ParseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ParseToolStripMenuItem1.Click
        If Len(Me.tbMain.Text) = 0 Then
            Me.tbMain.Text = "{""SayInf"":""Hello World""}"
            Dim strDisplay As String = ""
            strDisplay &= vbCrLf & "***" & sender.ToString & " Sample code***" & vbCrLf
            strDisplay &= "```" & vbCrLf
            strDisplay &= "pjParse = New PigJSon(""{""""SayInf"""":""""Hello World""""}"")" & vbCrLf
            strDisplay &= "If pjParse.LastErr <> """" Then" & vbCrLf
            strDisplay &= vbTab & "Debug.Print(pjParse.GetStrValue(""SayInf""))" & vbCrLf
            strDisplay &= "End If" & vbCrLf
            strDisplay &= "```" & vbCrLf
            pjParse = New PigJSon(Me.tbMain.Text)
            If pjParse.LastErr = "" Then
                strDisplay &= vbCrLf & "***Return results***" & vbCrLf
                strDisplay &= "```" & vbCrLf
                strDisplay &= pjParse.GetStrValue("SayInf") & vbCrLf
                strDisplay &= "```" & vbCrLf
                Me.tbMain.Text &= strDisplay
            End If
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
        strDisplay &= vbCrLf & "***" & sender.ToString & " Sample code***" & vbCrLf
        strDisplay &= "```" & vbCrLf
        strDisplay &= "pjAssemble = New PigJSon" & vbCrLf
        strDisplay &= "With pjAssemble" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""SiteName"", ""Seow Phong Web Site"", True)    'The first element needs to be explicitly specified" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""SiteUrl"", ""http://www.seowphong.com"")  'The default is not the first element" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""Describe"", ""A website for free software"" & vbCrLf & "" and shareware"") 'The text contains a carriage return" & vbCrLf
        strDisplay &= vbTab & ".AddSymbol(PigJSon.xpSymbolType.EleEndFlag)" & vbCrLf
        strDisplay &= vbTab & "If .ParseJSON() = ""OK"" Then" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.MainJSonStr)" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""SiteName""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""SiteUrl""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""Describe""))" & vbCrLf
        strDisplay &= vbTab & "End If" & vbCrLf
        strDisplay &= "End With" & vbCrLf
        strDisplay &= "```" & vbCrLf

        pjAssemble = New PigJSon
        With pjAssemble
            .AddEle("SiteName", "Seow Phong Web Site", True)    'The first element needs to be explicitly specified
            .AddEle("SiteUrl", "http://www.seowphong.com")  'The default is not the first element
            .AddEle("Describe", "A website for free software" & vbCrLf & " and shareware")  'The text contains a carriage return
            .AddSymbol(PigJSon.xpSymbolType.EleEndFlag)
            strRet = .ParseJSON()
            If strRet = "OK" Then
                strDisplay &= vbCrLf & "***Return results***" & vbCrLf
                strDisplay &= "```" & vbCrLf
                strDisplay &= .MainJSonStr & vbCrLf
                strDisplay &= .GetStrValue("SiteName") & vbCrLf
                strDisplay &= .GetStrValue("SiteUrl") & vbCrLf
                strDisplay &= .GetStrValue("Describe") & vbCrLf
                strDisplay &= "```" & vbCrLf
            End If
        End With
        Me.tbMain.Text = strDisplay
    End Sub

    Private Sub SimpleTextElementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpleTextElementsToolStripMenuItem.Click
        Dim strDisplay As String = ""
        strDisplay &= vbCrLf & "***" & sender.ToString & " Sample code***" & vbCrLf
        strDisplay &= "```" & vbCrLf
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
        strDisplay &= vbTab & "If .ParseJSON() = ""OK"" Then" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.MainJSonStr)" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""SiteName""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""SiteUrl""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""Describe""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetIntValue(""Rank"").ToString)" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetDecValue(""VisitPerDay"").ToString)" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""VisitTimeStr""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetDateValue(""VisitTime"").ToString)" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetDateValue(""VisitTimeGT"", False).ToString)" & vbCrLf
        strDisplay &= vbTab & "End If" & vbCrLf
        strDisplay &= "End With" & vbCrLf
        strDisplay &= "```" & vbCrLf

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
            If .ParseJSON() = "OK" Then
                strDisplay &= vbCrLf & "***Return results***" & vbCrLf
                strDisplay &= "```" & vbCrLf
                strDisplay &= .MainJSonStr & vbCrLf
                strDisplay &= .GetStrValue("SiteName") & vbCrLf
                strDisplay &= .GetStrValue("SiteUrl") & vbCrLf
                strDisplay &= .GetStrValue("Describe") & vbCrLf
                strDisplay &= .GetIntValue("Rank").ToString & vbCrLf
                strDisplay &= .GetDecValue("VisitPerDay").ToString & vbCrLf
                strDisplay &= .GetStrValue("VisitTimeStr") & vbCrLf
                strDisplay &= .GetDateValue("VisitTime").ToString & vbCrLf
                strDisplay &= .GetDateValue("VisitTimeGT", False).ToString & vbCrLf
                strDisplay &= "```" & vbCrLf
            End If
        End With
        Me.tbMain.Text = strDisplay
    End Sub

    Private Sub SimpleArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpleArrayToolStripMenuItem.Click
        Dim strDisplay As String = ""
        strDisplay &= vbCrLf & "***" & sender.ToString & " Sample code***" & vbCrLf
        strDisplay &= "```" & vbCrLf
        strDisplay &= "pjArray = New PigJSon" & vbCrLf
        strDisplay &= "With pjArray" & vbCrLf
        strDisplay &= vbTab & "'In this way, the content of the array element will be escaped." & vbCrLf
        strDisplay &= vbTab & ".AddEle("""", ""Google"", True)" & vbCrLf
        strDisplay &= vbTab & ".AddEle("""", ""GitHub"")" & vbCrLf
        strDisplay &= vbTab & ".AddEle("""", ""Apache"")" & vbCrLf
        strDisplay &= "End With" & vbCrLf
        strDisplay &= "pjAssemble = New PigJSon" & vbCrLf
        strDisplay &= "With pjAssemble" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""TotalSites"", 3, True)" & vbCrLf
        strDisplay &= vbTab & ".AddOneArrayEle(""SitesList"", pjArray.MainJSonStr)" & vbCrLf
        strDisplay &= vbTab & ".AddSymbol(PigJSon.xpSymbolType.EleEndFlag)" & vbCrLf
        strDisplay &= vbTab & "If .ParseJSON() = ""OK"" Then" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.MainJSonStr)" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetIntValue(""TotalSites"").ToString)" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""SitesList[0]""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""SitesList[1]""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""SitesList[2]""))" & vbCrLf
        strDisplay &= vbTab & "End If" & vbCrLf
        strDisplay &= "End With" & vbCrLf
        strDisplay &= "```" & vbCrLf

        Dim pjArray As PigJSon
        pjArray = New PigJSon
        With pjArray
            .AddEle("", "Google", True)
            .AddEle("", "GitHub")
            .AddEle("", "Apache")
        End With
        pjAssemble = New PigJSon
        With pjAssemble
            .AddEle("TotalSites", 3, True)
            .AddOneArrayEle("SitesList", pjArray.MainJSonStr)
            .AddSymbol(PigJSon.xpSymbolType.EleEndFlag)
            If .ParseJSON() = "OK" Then
                strDisplay &= vbCrLf & "***Return results***" & vbCrLf
                strDisplay &= "```" & vbCrLf
                strDisplay &= .MainJSonStr & vbCrLf
                strDisplay &= .GetIntValue("TotalSites").ToString & vbCrLf
                strDisplay &= .GetStrValue("SitesList[0]") & vbCrLf
                strDisplay &= .GetStrValue("SitesList[1]") & vbCrLf
                strDisplay &= .GetStrValue("SitesList[2]") & vbCrLf
                strDisplay &= "```" & vbCrLf
            End If
        End With
        Me.tbMain.Text = strDisplay
    End Sub

    Private Sub SimpleArrayElementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpleArrayElementsToolStripMenuItem.Click
        Dim strDisplay As String = ""
        strDisplay &= vbCrLf & "***" & sender.ToString & " Sample code***" & vbCrLf
        strDisplay &= "```" & vbCrLf
        strDisplay &= "pjOneCompany = New PigJSon" & vbCrLf
        strDisplay &= "pjArray = New PigJSon" & vbCrLf
        strDisplay &= "pjAssemble = New PigJSon" & vbCrLf
        strDisplay &= "With pjAssemble" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""Name"", ""Company products"", True)" & vbCrLf
        strDisplay &= vbTab & ".AddArrayEleBegin(""CompanyProductList"")" & vbCrLf
        strDisplay &= vbTab & "With pjArray" & vbCrLf
        strDisplay &= vbTab & vbTab & ".Reset()" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddEle("""", ""Windows"", True)" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddEle("""", ""SQL Server"")" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddEle("""", ""Office"")" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddEle("""", ""Azure"")" & vbCrLf
        strDisplay &= vbTab & "End With" & vbCrLf
        strDisplay &= vbTab & "With pjOneCompany" & vbCrLf
        strDisplay &= vbTab & vbTab & ".Reset()" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddOneArrayEle(""ProductList"", pjArray.MainJSonStr, True)" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddEle(""CompanyName"", ""Microsoft"")" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddSymbol(PigJSon.xpSymbolType.EleEndFlag)" & vbCrLf
        strDisplay &= vbTab & "End With" & vbCrLf
        strDisplay &= vbTab & ".AddArrayEleValue(pjOneCompany.MainJSonStr, True)" & vbCrLf
        strDisplay &= vbTab & "With pjArray" & vbCrLf
        strDisplay &= vbTab & vbTab & ".Reset()" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddEle("""", ""Chrome"", True)" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddEle("""", ""YouTube"")" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddEle("""", ""Android"")" & vbCrLf
        strDisplay &= vbTab & "End With" & vbCrLf
        strDisplay &= vbTab & "With pjOneCompany" & vbCrLf
        strDisplay &= vbTab & vbTab & ".Reset()" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddEle(""CompanyName"", ""Google"", True)" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddOneArrayEle(""ProductList"", pjArray.MainJSonStr)" & vbCrLf
        strDisplay &= vbTab & vbTab & ".AddSymbol(PigJSon.xpSymbolType.EleEndFlag)" & vbCrLf
        strDisplay &= vbTab & "End With" & vbCrLf
        strDisplay &= vbTab & ".AddArrayEleValue(pjOneCompany.MainJSonStr)" & vbCrLf
        strDisplay &= vbTab & ".AddSymbol(PigJSon.xpSymbolType.ArrayEndFlag)" & vbCrLf
        strDisplay &= vbTab & ".AddEle(""TotalCompanies"", 2)" & vbCrLf
        strDisplay &= vbTab & ".AddSymbol(PigJSon.xpSymbolType.EleEndFlag)" & vbCrLf
        strDisplay &= vbTab & "If .ParseJSON() = ""OK"" Then" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.MainJSonStr)" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""Name""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetIntValue(""TotalCompanies"").ToString)" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""CompanyProductList[0].CompanyName""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""CompanyProductList[0].ProductList[2]""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""CompanyProductList[0].ProductList[3]""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""CompanyProductList[1].CompanyName""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""CompanyProductList[1].ProductList[1]""))" & vbCrLf
        strDisplay &= vbTab & vbTab & "Debug.Print(.GetStrValue(""CompanyProductList[1].ProductList[2]""))" & vbCrLf
        strDisplay &= vbTab & "End If" & vbCrLf
        strDisplay &= "End With" & vbCrLf
        strDisplay &= "```" & vbCrLf

        Dim pjOneCompany As PigJSon
        Dim pjArray As PigJSon
        pjOneCompany = New PigJSon
        pjArray = New PigJSon
        pjAssemble = New PigJSon
        With pjAssemble
            .AddEle("Name", "Company products", True)
            .AddArrayEleBegin("CompanyProductList")
            With pjArray
                .Reset()
                .AddEle("", "Windows", True)
                .AddEle("", "SQL Server")
                .AddEle("", "Office")
                .AddEle("", "Azure")
            End With
            With pjOneCompany
                .Reset()
                .AddOneArrayEle("ProductList", pjArray.MainJSonStr, True)
                .AddEle("CompanyName", "Microsoft")
                .AddSymbol(PigJSon.xpSymbolType.EleEndFlag)
            End With
            .AddArrayEleValue(pjOneCompany.MainJSonStr, True)
            With pjArray
                .Reset()
                .AddEle("", "Chrome", True)
                .AddEle("", "YouTube")
                .AddEle("", "Android")
            End With
            With pjOneCompany
                .Reset()
                .AddEle("CompanyName", "Google", True)
                .AddOneArrayEle("ProductList", pjArray.MainJSonStr)
                .AddSymbol(PigJSon.xpSymbolType.EleEndFlag)
            End With
            .AddArrayEleValue(pjOneCompany.MainJSonStr)
            .AddSymbol(PigJSon.xpSymbolType.ArrayEndFlag)
            .AddEle("TotalCompanies", 2)
            .AddSymbol(PigJSon.xpSymbolType.EleEndFlag)
            If .ParseJSON() = "OK" Then
                strDisplay &= vbCrLf & "***Return results***" & vbCrLf
                strDisplay &= "```" & vbCrLf
                strDisplay &= .MainJSonStr & vbCrLf
                strDisplay &= .GetStrValue("Name") & vbCrLf
                strDisplay &= .GetIntValue("TotalCompanies").ToString & vbCrLf
                strDisplay &= .GetStrValue("CompanyProductList[0].CompanyName") & vbCrLf
                strDisplay &= .GetStrValue("CompanyProductList[0].ProductList[2]") & vbCrLf
                strDisplay &= .GetStrValue("CompanyProductList[0].ProductList[3]") & vbCrLf
                strDisplay &= .GetStrValue("CompanyProductList[1].CompanyName") & vbCrLf
                strDisplay &= .GetStrValue("CompanyProductList[1].ProductList[1]") & vbCrLf
                strDisplay &= .GetStrValue("CompanyProductList[1].ProductList[2]") & vbCrLf
                strDisplay &= "```" & vbCrLf
            End If
        End With
        Me.tbMain.Text = strDisplay
    End Sub
End Class

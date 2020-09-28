# PigJSon
Piggy JSON is a very simple JSON parsing and assembly toolkit that can support VB.net And C#, if used vb.net You just need to PigJSon.vb Add to the. Net project to use.

## ***Folder description***

### Src

Source code directory

#### Src\VB.net

VB.net Example, in VB.net In the project, we only need to add PigJSon.vb This class file, you can parse and assemble JSON.

### Bin

Execute code directory, if you don't want to see the source program, you can use the files in this directory directly in your VB.NET Or C# project.

***Parse JSon Sample code***

```
pjParse = New PigJSon("{""SayInf"":""Hello World""}")
If pjParse.LastErr = "" Then
	Debug.Print(pjParse.GetStrValue("SayInf"))
End If
```

***Return results***
```
Hello World
```

***Simple text elements Sample code***

```visual basic
pjAssemble = New PigJSon
With pjAssemble
	.AddEle("SiteName", "Seow Phong Web Site", True)    'The first element needs to be explicitly specified
	.AddEle("SiteUrl", "http://www.seowphong.com")  'The default is not the first element
	.AddEle("Describe", "A website for free software" & vbCrLf & " and shareware") 'The text contains a carriage return
	.AddSymbol(PigJSon.xpSymbolType.EleEndFlag)
	If .ParseJSON() = "OK" Then
		Debug.Print(.MainJSonStr)
		Debug.Print(.GetStrValue("SiteName"))
		Debug.Print(.GetStrValue("SiteUrl"))
		Debug.Print(.GetStrValue("Describe"))
	End If
End With
```

***Return results***
```
{"SiteName":"Seow Phong Web Site","SiteUrl":"http://www.seowphong.com","Describe":"A website for free software\r\n and shareware"}
Seow Phong Web Site
http://www.seowphong.com
A website for free software
 and shareware
```


***Simple multiple data types elements Sample code***
```
pjAssemble = New PigJSon
With pjAssemble
	.AddEle("SiteName", "Seow Phong Web Site", True)    'The first element needs to be explicitly specified
	.AddEle("SiteUrl", "http://www.seowphong.com")  'The default is not the first element
	.AddEle("Describe", "A website for free software" & vbCrLf & " and shareware") 'The text contains a carriage return
	.AddEle("Rank", 168)
	.AddEle("VisitPerDay", CDec(168.88))
	.AddEle("VisitTimeStr", "8/8/2020")
	.AddEle("VisitTime", Now)
	.AddEle("VisitTimeGT", Now, False, False)   'Global time
	.AddSymbol(PigJSon.xpSymbolType.EleEndFlag)
	If .ParseJSON() = "OK" Then
		Debug.Print(.MainJSonStr)
		Debug.Print(.GetStrValue("SiteName"))
		Debug.Print(.GetStrValue("SiteUrl"))
		Debug.Print(.GetStrValue("Describe"))
		Debug.Print(.GetIntValue("Rank").ToString)
		Debug.Print(.GetDecValue("VisitPerDay").ToString)
		Debug.Print(.GetStrValue("VisitTimeStr"))
		Debug.Print(.GetDateValue("VisitTime").ToString)
		Debug.Print(.GetDateValue("VisitTimeGT", False).ToString)
	End If
End With
```

***Return results***
```
{"SiteName":"Seow Phong Web Site","SiteUrl":"http://www.seowphong.com","Describe":"A website for free software\r\n and shareware","Rank":"168","VisitPerDay":"168.88","VisitTimeStr":"8/8/2020","VisitTime":"1601242412742","VisitTimeGT":"1601213612755"}
Seow Phong Web Site
http://www.seowphong.com
A website for free software
 and shareware
168
168.88
8/8/2020
2020/9/27 21:33:32
2020/9/27 13:33:32
```

***Simple array elements Sample code***
```
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
		Debug.Print(.MainJSonStr)
		Debug.Print(.GetIntValue("TotalSites").ToString)
		Debug.Print(.GetStrValue("SitesList[0]"))
		Debug.Print(.GetStrValue("SitesList[1]"))
		Debug.Print(.GetStrValue("SitesList[2]"))
	End If
End With
```

***Return results***
```
{"TotalSites":"3","SitesList":["Google","GitHub","Apache"]}
3
Google
GitHub
Apache
```

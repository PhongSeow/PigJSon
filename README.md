# PigJSon
Piggy JSON is a very simple JSON parsing and assembly toolkit that can support VB.net And C#, if used vb.net You just need to PigJSon.vb Add to the. Net project to use.

##***Folder description***

###Src

Source code directory

####Src\VB.net

VB.net Example, in VB.net In the project, we only need to add PigJSon.vb This class file, you can parse and assemble JSON.

###Bin

Execute code directory, if you don't want to see the source program, you can use the files in this directory directly in your VB.NET Or C# project.

***Simple text elements Sample code***
```
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


# PigJSon
Piggy JSON is a very simple JSON parsing and assembly toolkit that can support VB.net And C#, if used vb.net You just need to PigJSon.vb Add to the. Net project to use.

Folder description

Src

Source code directory

Src\VB.net

VB.net Example, in VB.net In the project, we only need to add PigJSon.vb This class file, you can parse and assemble JSON.

Bin

Execute code directory, if you don't want to see the source program, you can use the files in this directory directly in your VB.NET Or C# project.


***Simple text elements Sample code***
pjAssemble = New PigJSon
With pjAssemble
	.AddEle("SiteName", "Soew Phong Web Site", True)    'The first element needs to be explicitly specified
	.AddEle("SiteUrl", "http://www.sewophong.com")  'The default is not the first element
	.AddEle("Describe", "A website for free software" & vbCrLf & " and shareware") 'The text contains a carriage return
	.AddSymbol(PigJSon.xpSymbolType.EleEndFlag)
End With
***Return results***
MainJSonStr={"SiteName":"Soew Phong Web Site","SiteUrl":"http://www.sewophong.com","Describe":"A website for free software\r\n and shareware"}
ParseJSON=OK
With pjAssemble
	.GetStrValue("SiteName")=Soew Phong Web Site
	.GetStrValue("SiteUrl")=http://www.sewophong.com
	.GetStrValue("Describe")=A website for free software
 and shareware
End With

***Simple multiple data types elements Sample code***
pjAssemble = New PigJSon
With pjAssemble
	.AddEle("SiteName", "Soew Phong Web Site", True)    'The first element needs to be explicitly specified
	.AddEle("SiteUrl", "http://www.sewophong.com")  'The default is not the first element
	.AddEle("Describe", "A website for free software" & vbCrLf & " and shareware") 'The text contains a carriage return
	.AddEle("Rank", 168)
	.AddEle("VisitPerDay", CDec(168.88))
	.AddEle("VisitTimeStr", "8/8/2020")
	.AddEle("VisitTime", Now)
	.AddEle("VisitTimeGT", Now, False, False)   'Global time
	.AddSymbol(PigJSon.xpSymbolType.EleEndFlag)
End With
***Return results***
MainJSonStr={"SiteName":"Soew Phong Web Site","SiteUrl":"http://www.sewophong.com","Describe":"A website for free software\r\n and shareware","Rank":"168","VisitPerDay":"168.88","VisitTimeStr":"8/8/2020","VisitTime":"1601154374544","VisitTimeGT":"1601125574556"}
ParseJSON=OK
With pjAssemble
	.GetStrValue("SiteName")=Soew Phong Web Site
	.GetStrValue("SiteUrl")=http://www.sewophong.com
	.GetStrValue("Describe")=A website for free software
 and shareware
	.GetIntValue("Rank")=168
	.GetDecValue("VisitPerDay")=168.88
	.GetStrValue("VisitTimeStr")=8/8/2020
	.GetDateValue("VisitTime")=2020/9/26 21:06:14
	.GetDateValue("VisitTimeGT", False)=2020/9/26 13:06:14
End With

***Simple array Sample code***
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
End With
***Return results***
MainJSonStr={"Sites":["Google","GitHub","Apache"]}
ParseJSON=OK
With pjAssemble
	.GetStrValue("Sites[0]")=Google
	.GetStrValue("Sites[1]")=GitHub
	.GetStrValue("Sites[2]")=Apache
End With

# PigJSon
Piggy JSON is a very simple JSON parsing and assembly toolkit that can support VB.net And C#, if used vb.net You just need to PigJSon.vb Add to the. Net project to use.

Folder description

Src

Source code directory

Src\VB.net

VB.net Example, in VB.net In the project, we only need to add PigJSon.vb This class file, you can parse and assemble JSON.

Bin

Execute code directory, if you don't want to see the source program, you can use the files in this directory directly in your VB.NET Or C# project.


<br>
***Simple text elements Sample code***<br>
pjAssemble = New PigJSon<br>
With pjAssemble<br>
&nbsp;&nbsp;&nbsp;&nbsp;.AddEle("SiteName", "Soew Phong Web Site", True)    'The first element needs to be explicitly specified<br>
&nbsp;&nbsp;&nbsp;&nbsp;.AddEle("SiteUrl", "http://www.sewophong.com")  'The default is not the first element<br>
&nbsp;&nbsp;&nbsp;&nbsp;.AddEle("Describe", "A website for free software" & vbCrLf & " and shareware") 'The text contains a carriage return<br>
&nbsp;&nbsp;&nbsp;&nbsp;.AddSymbol(PigJSon.xpSymbolType.EleEndFlag)<br>
End With<br>
***Return results***<br>
MainJSonStr={"SiteName":"Soew Phong Web Site","SiteUrl":"http://www.sewophong.com","Describe":"A website for free software\r\n and shareware"}<br>
ParseJSON=OK<br>
With pjAssemble<br>
&nbsp;&nbsp;&nbsp;&nbsp;.GetStrValue("SiteName")=Soew Phong Web Site<br>
&nbsp;&nbsp;&nbsp;&nbsp;.GetStrValue("SiteUrl")=http://www.sewophong.com<br>
&nbsp;&nbsp;&nbsp;&nbsp;.GetStrValue("Describe")=A website for free software<br>
 and shareware<br>
End With<br>
<br>
***Simple multiple data types elements Sample code***<br>
pjAssemble = New PigJSon<br>
With pjAssemble<br>
&nbsp;&nbsp;&nbsp;&nbsp;.AddEle("SiteName", "Soew Phong Web Site", True)    'The first element needs to be explicitly specified<br>
&nbsp;&nbsp;&nbsp;&nbsp;.AddEle("SiteUrl", "http://www.sewophong.com")  'The default is not the first element<br>
&nbsp;&nbsp;&nbsp;&nbsp;.AddEle("Describe", "A website for free software" & vbCrLf & " and shareware") 'The text contains a carriage return<br>
&nbsp;&nbsp;&nbsp;&nbsp;.AddEle("Rank", 168)<br>
&nbsp;&nbsp;&nbsp;&nbsp;.AddEle("VisitPerDay", CDec(168.88))<br>
&nbsp;&nbsp;&nbsp;&nbsp;.AddEle("VisitTimeStr", "8/8/2020")<br>
&nbsp;&nbsp;&nbsp;&nbsp;.AddEle("VisitTime", Now)<br>
&nbsp;&nbsp;&nbsp;&nbsp;.AddEle("VisitTimeGT", Now, False, False)   'Global time<br>
&nbsp;&nbsp;&nbsp;&nbsp;.AddSymbol(PigJSon.xpSymbolType.EleEndFlag)<br>
End With<br>
***Return results***<br>
MainJSonStr={"SiteName":"Soew Phong Web Site","SiteUrl":"http://www.sewophong.com","Describe":"A website for free software\r\n and shareware","Rank":"168","VisitPerDay":"168.88","VisitTimeStr":"8/8/2020","VisitTime":"1601154374544","VisitTimeGT":"1601125574556"}<br>
ParseJSON=OK<br>
With pjAssemble<br>
&nbsp;&nbsp;&nbsp;&nbsp;.GetStrValue("SiteName")=Soew Phong Web Site<br>
&nbsp;&nbsp;&nbsp;&nbsp;.GetStrValue("SiteUrl")=http://www.sewophong.com<br>
&nbsp;&nbsp;&nbsp;&nbsp;.GetStrValue("Describe")=A website for free software<br>
 and shareware<br>
&nbsp;&nbsp;&nbsp;&nbsp;.GetIntValue("Rank")=168<br>
&nbsp;&nbsp;&nbsp;&nbsp;.GetDecValue("VisitPerDay")=168.88<br>
&nbsp;&nbsp;&nbsp;&nbsp;.GetStrValue("VisitTimeStr")=8/8/2020<br>
&nbsp;&nbsp;&nbsp;&nbsp;.GetDateValue("VisitTime")=2020/9/26 21:06:14<br>
&nbsp;&nbsp;&nbsp;&nbsp;.GetDateValue("VisitTimeGT", False)=2020/9/26 13:06:14<br>
End With<br>
<br>
***Simple array Sample code***<br>
pjArray = New PigJSon<br>
With pjArray<br>
&nbsp;&nbsp;&nbsp;&nbsp;.AddEle("", "Google", True)<br>
&nbsp;&nbsp;&nbsp;&nbsp;.AddEle("", "GitHub")<br>
&nbsp;&nbsp;&nbsp;&nbsp;.AddEle("", "Apache")<br>
End With<br>
pjAssemble = New PigJSon<br>
With pjAssemble<br>
&nbsp;&nbsp;&nbsp;&nbsp;.AddOneArrayEle("Sites", pjArray.MainJSonStr, True)<br>
&nbsp;&nbsp;&nbsp;&nbsp;.AddSymbol(PigJSon.xpSymbolType.EleEndFlag)<br>
End With<br>
***Return results***<br>
MainJSonStr={"Sites":["Google","GitHub","Apache"]}<br>
ParseJSON=OK<br>
With pjAssemble<br>
&nbsp;&nbsp;&nbsp;&nbsp;.GetStrValue("Sites[0]")=Google<br>
&nbsp;&nbsp;&nbsp;&nbsp;.GetStrValue("Sites[1]")=GitHub<br>
&nbsp;&nbsp;&nbsp;&nbsp;.GetStrValue("Sites[2]")=Apache<br>
End With<br>

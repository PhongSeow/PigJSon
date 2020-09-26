# PigJSon
Piggy JSON is a very simple JSON parsing and assembly toolkit that can support VB.net And C#, if used vb.net You just need to PigJSon.vb Add to the. Net project to use.

Folder description

Src

Source code directory

Src\VB.net

VB.net Example, in VB.net In the project, we only need to add PigJSon.vb This class file, you can parse and assemble JSON.

Bin

Execute code directory, if you don't want to see the source program, you can use the files in this directory directly in your VB.NET Or C# project.

***Simple text elements Sample code***<br>
pjAssemble = New PigJSon<br>
With pjAssemble<br>
&nbsp;&nbsp;&nbsp;&nbsp;.AddEle("SiteName", "Seow Phong Web Site", True)    'The first element needs to be explicitly specified<br>
&nbsp;&nbsp;&nbsp;&nbsp;.AddEle("SiteUrl", "http://www.seowphong.com")  'The default is not the first element<br>
&nbsp;&nbsp;&nbsp;&nbsp;.AddEle("Describe", "A website for free software" & vbCrLf & " and shareware") 'The text contains a carriage return<br>
&nbsp;&nbsp;&nbsp;&nbsp;.AddSymbol(PigJSon.xpSymbolType.EleEndFlag)<br>
&nbsp;&nbsp;&nbsp;&nbsp;.ParseJSON()<br>
&nbsp;&nbsp;&nbsp;&nbsp;Debug.Print(.MainJSonStr)<br>
&nbsp;&nbsp;&nbsp;&nbsp;Debug.Print(.GetStrValue("SiteName"))<br>
&nbsp;&nbsp;&nbsp;&nbsp;Debug.Print(.GetStrValue("SiteUrl"))<br>
&nbsp;&nbsp;&nbsp;&nbsp;Debug.Print(.GetStrValue("Describe"))<br>
End With<br>
***Return results***<br>
{"SiteName":"Seow Phong Web Site","SiteUrl":"http://www.seowphong.com","Describe":"A website for free software\r\n and shareware"}<br>
Seow Phong Web Site<br>
http://www.seowphong.com<br>
A website for free software<br>
 and shareware<br>

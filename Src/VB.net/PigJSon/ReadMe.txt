Piggy JSon 是一个非常简单的JSon工具包，它不需要DLL就能够使用，只需要将 PigJSon.vb 添加到 .net 工程就可以。
Piggy JSon 可以解析JSon 和 组装JSon字符串。
解析JSon 的方法是：可以在 New PigJSon 时，或者是使用 ParseJSON 方法。

，通过重载函数 AddEle 可以将原始的数据类型值转化成JSon文本，对回车符和制表符等特殊字符会自动转义。

***Sample code***
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
MainJSonStr={"SiteName":"Soew Phong Web Site","SiteUrl":"http://www.sewophong.com","Describe":"A website for free software\r\n and shareware","Rank":"168","VisitPerDay":"168.88","VisitTimeStr":"8/8/2020","VisitTime":"1597765343553","VisitTimeGT":"1597736543556"}
SiteName=Soew Phong Web Site
SiteUrl=http://www.sewophong.com
Rank=168
VisitPerDay=168.88
VisitTimeStr=8/8/2020
VisitTime=2020/8/18 15:42:23
VisitTimeGT=2020/8/18 7:42:23

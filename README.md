# PigJSon
Piggy JSON is A very lightweight JSON parsing and assembly toolkit.

## ***Folders and files description***

### Release

Release execute code directory, if you don't want to see the source program, you can use the files in this directory directly in your VB.NET project.

#### Release\PigJSonLib

Including  DLL file support .net Framework 2.0, 3.5, 4.0, 4.5, .net core 3.1 and .net 5.0.

Including NuGet package.



##### [Release\Demo\Sample.md](https://github.com/PhongSeow/PigJSon/blob/master/Release\Demo/Sample.md)

Sample code for how to use the PigJSonLib class.



### Src

Source code directory.

#### Src\DotNet\PigJSonLib

The source code of PigJSonLib.

#### Src\VB.net

PigJSon VB.net Version of the source code.

***Sample code***

```
pjParse = New PigJSon("{""SayInf"":""Hello World""}")
If pjParse.LastErr = "" Then
	Debug.Print(pjParse.GetStrValue("SayInf"))
End If
```

***[See more sample code...](https://github.com/PhongSeow/PigJSon/blob/master/Setup/VB.net/Sample.md)***

##### Src\VB.net\PigJSon\PigJSon.sln

Open the SLN file to view and debug the source code of PigJSon.

##### Src\VB.net\PigJSon\PigJSon\PigJSon.vb

Main class, all functions are in it.

##### Src\VB.net\PigJSon\PigJSon\frmPigJSonDemo.vb

Sample code form.



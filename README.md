# PigJSon
Piggy JSON is a very lightweight JSON parsing and assembly toolkit that can support VB.net, You can use JSON in. Net without referring to a DLL, just need a class file.

## ***Folders and files description***

### Run

Execute code directory, if you don't want to see the source program, you can use the files in this directory directly in your VB.NET project.

#### Run\VB.net

The execution code uses. Net framework 4.5.

##### Run\VB.net\PigJSon.vb

In your vb.net This class file can be referenced in the project to obtain the parsing and assembly capabilities of JSON.

##### Run\VB.net\PigJSon.exe

The execution effect of the sample code.

##### [Run\VB.net\Sample.md](https://github.com/PhongSeow/PigJSon/blob/master/Run/VB.net/Sample.md)

Sample code for how to use the PigJSon class.

## 

### Src

Source code directory.

#### Src\VB.net

PigJSon VB.net Version of the source code.

The source code uses. Net framework 4.5.

***Sample code***

```
pjParse = New PigJSon("{""SayInf"":""Hello World""}")
If pjParse.LastErr = "" Then
	Debug.Print(pjParse.GetStrValue("SayInf"))
End If
```

***[See more sample code...](https://github.com/PhongSeow/PigJSon/blob/master/Run/VB.net/Sample.md)***

##### Src\VB.net\PigJSon\PigJSon.sln

Open the SLN file to view and debug the source code of PigJSon.

##### Src\VB.net\PigJSon\PigJSon\PigJSon.vb

Main class, all functions are in it.

##### Src\VB.net\PigJSon\PigJSon\frmPigJSonDemo.vb

Sample code form.






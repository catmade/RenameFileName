# 批量修改文件名
本程序只能将文件名中不必要的`0`去除，比如：`001.a` -> `1.a`  

如果有自己的需求的话，只需要自己更改以下函数的代码即可
```
/// <summary>
/// 将文件名转化成用户需要的名字
/// </summary>
/// <param name="name">被更改的文件名</param>
/// <returns>修改后的文件名</returns>
private string Form1.GetTargetFileName(string name)
```
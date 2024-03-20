# 这是什么
由于部分用户显存较小，在GTA5占用了大部分显存的情况下加载全部中文会导致崩溃或菜单无法显示。因此只能按需加载中文字符。在Yimmenu的源码中使用unicode的累积偏移表示需要加载的中文字符范围。\
此程序的作用是根据给出的需要加载的中文字符生成可以直接导入到Yimmenu的偏移。
# 目录结构
```
-res
  -currentYim.txt Yimmenu当前使用的全部中文表
  -gtaoTR+yimTR.txt GTA5和Yimmenu简体、繁体翻译json文件中出现的全部繁体中文字符
  -gtaoxtchschars.txt GTA5游戏内出现的所有简体、繁体中文字符
  -简体三级字表officalzhcn3.txt 是姓氏人名、地名、科学技术术语和中小学语文教材文言文用字中未进入一、二级字表的较通用的字
  -简体一二级字表officalzhcn12.txt 简体中文一级字表（为常用字集，收字3500个，主要满足基础教育和文化普及的基本用字需要） + 简体中文二级字表（收字3000个，使用度仅次于一级字）
  -简体一二三级字表officalzhcn123.txt 全部官方简体中文
-Program.cs 此程序c sharp代码
-unicode 2.csproj 此程序工程文件
-unicode 2.sln 此程序解决方案文件
```
# 如何维护
res/currentYim.txt 存储了Yimmenu当前使用的全部中文表，我将简体一二级字表和从GTA5游戏以及yimmenu中文翻译提取出的繁体字符组合成了此文件。此程序直接读取此文件用于生成偏移量。\
如果你发现有新的中文字符在yimmenu中显示为问号，请将对应的字符添加到red/currentYim.txt，然后运行此程序生成偏移量，将偏移量复制到Yimmenu的font_mgr.cpp的accumulative_offsets_from_0x4E00[] 数组中即可。
# FAQ
1.为什么要从GTA5提取中文字符？
答:Yimmenu的载具列表等资源是从GTA直接读取的，为正常显示生成载具的列表，必须额外考虑GTA的中文字符

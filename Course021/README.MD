### 第二十一天 MVVM

 1. 全局命令管理器 CommandManager 一个线程一直在刷CanExcute

 2.预制命令和内置命令 ApplicationCommands.New、Open、Copy				路由命令 RoutedUICommand RouteCommand

 预制命令可以使用一些快捷键，Open可以使用ctrl+o

 这个不能再ViewModel中处理

 3.鼠标事件，右键、双击、滚轮、中键

 4.任意事件在vm中绑定

 5.讲解框架之前的自定义简单实现
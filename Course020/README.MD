### 第二十天 MVVM

 1.  MVVM
 项目结构 
 Models: 存储数据模型
 Views: Window、Page、UserControl、
 ViewModels:关联Models和Views

 2.绑定表达式相当于订阅，数据变更之后，会触发通知

 3.Fody插件，添加注解【AddINotifyPropertyChangedInterface】之后，编译生成的代码会将属性全部变为带通知的属性，并且增加是否和之前值相同的判断

 [DoNotNotify] 不需要添加通知特性

 还有其他特性 
 【AlseNotifyFor】 实现通知的时候，同时通知其他属性
 【DependsOn】指定那些属性变化的时候，通知当前属性
 【DoNotCheckEquality】强制不做旧值比对

 Prism MvvmLight 框架封装的通知属性，已经增加了旧值比对
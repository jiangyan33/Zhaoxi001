### Course001

WPF和WindowForm
1.WPF表现层和逻辑层分离，比如Views和ViewModes,通过绑定表达式连接到一起(绑定的内容都是public 属性，有get;set;方法)

2.现在都不可移植到其他平台， .Net5或者.Net6是运行时跨平台，表现层现在不支持。

3.绘制复杂图形时，WPF是多个不同的控件拼装为一个，存在多个句柄，所见即所得。

4.WPF在逻辑层和表现层中间有一个数据模型，类似一个转换器，用来满足逻辑层和表现层的需求【隔山打牛】

5.事件驱动与数据驱动，比如通过点击按钮，触发一个事件，在这个事件中修改数据，数据变更后，自动更新到界面上（通过数据模型实现INotifyPropertyChanged接口），WPF也存在事件驱动

6.Model中的属性需要实现INotifyPropertyChanged,才可以通知到UI，不用整个ViewMode都实现，只需要把（数据改变后，需要通知到UI上的Mode进行操作(针对其中一个或者多个属性)）

7.基本属性绑定没有跨线程更新UI的问题，

8.UI绑定Model中的属性（包括基本属性和命令），Model中属性变更通知UI（实现INotifyPropertyChanged）

9.引用快捷键，Ctrl+.

10. Command 任意对象的任意事件都可以绑定

11. 性能两者差不多，WPF实现炫酷效果比较简单，完全使用代码进行UI布局
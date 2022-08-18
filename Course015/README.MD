### 第十五天 事件

 1.常用的输入事件

 wpf控件是没有句柄的，window有句柄，鼠标点击按钮后，window处理之后传递给按钮

 鼠标输入、键盘输入、

 

 事件执行过程中有可能会被拦截，无法执行，比如Button中的MouseLeftButtonDown。

 键盘按下Enter后会触发 IsDefault="True"按钮的Click事件

 触控相关事件，多点触控 TouchDown 手势笔，都有对应的事件

 2.行为封装   事件封装  Behaviors 针对blend   封装一个对象的多个事件到一个Behavior中
  
 3.路由事件

 逻辑树，控件之间的相互包含，一层套一层

 视觉树，一个控件展开之后的内容。呈现的视觉效果

 冒泡 MouseLeftButtonDown  Click
 
 隧道 PreviewMouseLeftButtonDown (由窗口传递到Grid再到Border)

 Window收到消息后，先隧道向下传递，再冒泡上来

 通过AddHandler方法，可以增加事件，即使e.handled=true，消息处理过了，也可以执行
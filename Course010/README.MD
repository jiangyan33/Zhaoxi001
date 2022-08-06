### 第十天

 1. 数据绑定的时候，如果只有一个{Binding},会一直向上查找元素的DataContext值，
  即绑定的时候没有指定Source或者ElementName，就从DataContext中取值

  2.在ViewModel更新基本属性的时候不会出现跨线程操作（修改），
  带通知的集合属性需要（会根据 数据模板动态生成子项，不能刷新太频繁，会导致UI假死）

  3.自定义List，带通知属性，变更集合元素，再通知到UI,比较复杂，每次更改后，都clear，然后全部加进来

  4.绑定 Mode=TwoWay,自读属性不支持TwoWay ,OneWay，从源到目标的绑定，
  默认的Model属性不同的控件不一样，textBlock的text是TwoWay
  绑定的依赖属性的设置的默认方式(new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));)

  5.UpdateSourceTrigger=PropertyChanged,当有这个设置的时候，每次更改都会触发ViewModel中的set方法，如果没有，当失去焦点时触发
   Explicit 明确的更新，需要通过代码手动触发，确认更改

6.OneWay的情况，如果对text进行赋值，this.textBox.text="123"，会切断绑定表达式（就不生效了） TwoWay不会切断

7.切断绑定关系 BindingOperations.ClearBinding(this.textBox,TextBox.TextProperty)

8.作业：根据第一次作业计算器进行功能扩展，添加计算的记录，记录以第二次自定义容器进行排列

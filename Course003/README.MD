### 第三天

1.继续布局控件

2.UniformGrid  UniformGrid 经常被Grid代替

3. 自定义WrapPanel的空间均分
 如果只有一列，子控件的最大宽度为整个控件的宽度，
 如果有多列，每一列的宽度相同

 4.依赖属性，使用DependencyProperty.Register进行注册，依赖附加属性使用DependencyProperty.RegisterAttached进行注册，
 布局控件中多是依赖附加属性，比如Grid中的Row,Column,依赖附加属性的的get set方法是静态的
 依赖属性多在自定义控件中  
  
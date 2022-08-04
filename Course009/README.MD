### 第九天

1.数据绑定，页面的依赖属性才可以进行绑定操作

2.绑定表达式 Source、ElementName、DataContext、RelativeSource+ Path

3.依赖属性，可以被绑定，当依赖属性发生更改时，可以通知绑定他的元素，如果不是依赖属性，需要实现INotifyPropertyChanged

4.绑定的时候如果是XML格式的数据，把Path换成XPath(多节点下标从1开始) 取节点属性时，通过@attr

5.绑定数据源类型 
	依赖对象
	普通数据类型或者集合数据数据类型
	单个对象，实现INotifyPropertyChanged
	XmlDataProvider
	ObjectDataProvider

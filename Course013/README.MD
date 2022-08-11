### 第十三天 图形与事件

 1.Path微语言
 M:移动命令，可以让线不连续
 L:直线绝对坐标
 H:水平绝对坐标
 V:水平绝对坐标
 (l,h,v是相对坐标，相对于前一个点,绝对坐标是相对于布局容器的左上角)

 圆弧 宽   高  旋转角度  是否优势弧   扫描方向  结束点
 A    180 150    60		1				0		300 400

 2.贝塞尔曲线 Q(2次) C（3次） 控制点、控制点、结束点（控制点连接到结束点的直线和曲线相切）

 3.平滑T（2次平滑） S(3次平滑)

 4.变形
 位移
 旋转
 缩放 变化的是坐标轴
 斜切
 矩阵 复杂，包含所有的变换

 5.画刷
 单色画刷(SolidColorBrush)
 线性渐变画刷(LinearGradientBrush)
 径向渐变(RadiaGradientBrush)
 图片画刷（ImageBrush）
 在背景上画图(DrawingBrush)
 虚拟画刷(VisualBrush)，将一个控件上的内容全部复制过来，可以用来设置倒影
 图像画刷（BitmapCacheBrush）将一个控件上的内容复制过来，不包括效果，可以设置效果

 6.Effect效果
 BlurEffect 模糊效果
 DropshadowEffect(阴影效果)
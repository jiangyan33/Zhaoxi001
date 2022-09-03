### 第十七天 动画

 1. 关键帧动画

 关键帧类型 
 Linear+[类型名称]+KeyFrame 线性变化关键帧

 DiscreteDoubleKeyFrame 离散变化关键帧，不连续变化（跳跃 ）

 SplineDoubleKeyFrame 样条关键帧（样条函数）二次贝塞尔曲线

 EasingDoubleKeyFrame 缓动式关键帧

 关键帧是把一个线性动画，划分为多个关键帧，每一个关键帧都是一个单独的动画

 路径动画 
 DoubleAnimationUsingPath 
 Matrix
 Point

 动画的一些扩展属性，如果需要可以查看文档，代码中没有给出

 动画的生命周期事件

 动画的控制

 动画的帧率，比如10，60，120 Timeline.DesireFrameRate 如果电脑配置不好可以把动画的帧率调整小一些

 动画内容细节内容太多了呀，可以做到更加精细的控制

 背景内容如果不怎么变化可以用 Polyline.CacheModel BitmapCache RenderAtScale="2"进行缓存

 <Polyline.CacheMode>
 <BitmapCache RenderAtScale="2"/>
  </Polyline.CacheMode>

2.作业 实现01、02、03的动画效果
### 第三十五天 多线程 

 1.常用API
 
 Task.waitAll()
 Task.WaitAny();

 会卡UI

 taskFactory.ContinueWhenAll()

 当所有线程都结束时执行，不会卡线程

 taskFactory.ContinueWhenAny()

 taskFactory和task可以在线程中传递参数


 2.捕获线程内部的异常

 需要进行线程等待，Task.waitAll(); 如果线程列表中存在多个异常，都会返回

 3.线程取消
 有一个全局变量cts CancellationTokenSource

 当开启一个线程的时候，可以传递一个参数 cts.Token，如果这个时候cts.IsCancellationRequested==true。
 这个线程就不会开启。

 抛出异常线程就停止了。
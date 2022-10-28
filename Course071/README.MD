### 第七十一天 上位机通信组件 Socket


 1.关闭时调用 
  socket.Shutdown(SocketShutdown.Both);

  socket.Dispose();

  socket.Send();

  socket.Receive();

  接收和发送都是使用byte[]  



 ### 第七十二天 上位机通信组件 Socket


 1.异步连接TCP服务端，BeginConnect，连接成功后，使用EndConnect结束这个异步对象。 同步连接失败的话需要20s左右的时间
  socket.Shutdown(SocketShutdown.Both);

  socket.Dispose();

  socket.Send();

  socket.Receive();

  接收和发送都是使用byte[]


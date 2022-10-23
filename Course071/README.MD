### 第七十一天 上位机通信组件 Socket


 1.关闭时调用 
  socket.Shutdown(SocketShutdown.Both);

  socket.Dispose();

  socket.Send();

  socket.Receive();

  接收和发送都是使用byte[]
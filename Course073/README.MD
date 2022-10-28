### 第七十三天 上位机通信组件 Socket


 1.TCP和UDP都是传输层协议。 TCP和TCP/IP是两个不同的协议

 2.打电话和发短信

 3.TCP可靠、保证数据不丢失、重复、按需到达（按照顺序来接收）； UDP不保证交付数据。

 4.TCPClient/TCPListener/UDPClient 里面封装的都是Socket

 5.TCP连接：3次握手， 客户端主动断开连接：4次挥手。 客户端+服务端一共发送3/4次

 6.通信库在PC上支持，移动端使用 System.IO.Ports会报错

 7.Socket对象是存在重试机制。
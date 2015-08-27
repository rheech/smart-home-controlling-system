package selab.SystemClient;

import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;

public class BroadcastSocket
{
	DatagramSocket socket;
	
	public BroadcastSocket()
	{
		try
		{
			socket = new DatagramSocket(8027);
			socket.setBroadcast(true);
			socket.connect(InetAddress.getByName("255.255.255.255"), 8027);
		}
		catch (Exception e)
		{
			System.err.println("Connection failed." + e.getMessage());
		}
	}
	
	public void listen()
	{
		new Thread()
		{
			public void run()
			{
				while (true)
				{
					try
					{
						byte[] buf = new byte[1000];
						DatagramPacket packet = new DatagramPacket(buf, buf.length);
						socket.receive(packet);
						String message = new String(buf);
						System.out.println("Received:" + message);
						if (message.equals("end"))
						{
							return;
						}
					}
					catch (Exception e)
					{
						System.err.println(e.getMessage());
					}
				}
			}
		}.start();
	}
	
	public void sendMessage(String message)
	{
		byte[] buf = message.getBytes();
		
		DatagramPacket packet = new DatagramPacket(buf, buf.length);
		
		try
		{
			socket.send(packet);
		}
		catch (Exception e)
		{
			System.err.println("Sending failed." + e.getMessage());
		}
	}
}

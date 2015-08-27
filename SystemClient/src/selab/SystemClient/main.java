package selab.SystemClient;

public class main
{

	public static void main(String[] args)
	{
		// TODO Auto-generated method stub
		BroadcastSocket socket = new BroadcastSocket();
		socket.sendMessage("Hello world!");
	}
}

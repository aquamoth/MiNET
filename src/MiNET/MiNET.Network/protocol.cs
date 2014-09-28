﻿
//
// WARNING: T4 GENERATED CODE - DO NOT EDIT
// 

using little = MiNET.Network.Int24; // friendly name

namespace MiNET.Network
{

	public class PackageFactory
	{
		public static Package CreatePackage(byte messageId, byte[] buffer)
		{
			Package package = null; 
			switch (messageId)
			{
				case 0x00:
					package = new ConnectedPing();
					package.Decode(buffer);
					return package;
				case 0x01:
					package = new UnconnectedPing();
					package.Decode(buffer);
					return package;
				case 0x03:
					package = new ConnectedPong();
					package.Decode(buffer);
					return package;
				case 0xc0:
					package = new Ack();
					package.Decode(buffer);
					return package;
				case 0xa0:
					package = new Nak();
					package.Decode(buffer);
					return package;
				case 0x1c:
					package = new UnconnectedPong();
					package.Decode(buffer);
					return package;
				case 0x05:
					package = new OpenConnectionRequest1();
					package.Decode(buffer);
					return package;
				case 0x06:
					package = new OpenConnectionReply1();
					package.Decode(buffer);
					return package;
				case 0x07:
					package = new OpenConnectionRequest2();
					package.Decode(buffer);
					return package;
				case 0x08:
					package = new OpenConnectionReply2();
					package.Decode(buffer);
					return package;
				case 0x09:
					package = new ConnectionRequest();
					package.Decode(buffer);
					return package;
				case 0x10:
					package = new ConnectionRequestAccepted();
					package.Decode(buffer);
					return package;
				case 0x13:
					package = new NewIncomingConnection();
					package.Decode(buffer);
					return package;
				case 0x82:
					package = new McpeLogin();
					package.Decode(buffer);
					return package;
				case 0x83:
					package = new McpeLoginStatus();
					package.Decode(buffer);
					return package;
				case 0x84:
					package = new McpeReady();
					package.Decode(buffer);
					return package;
				case 0x86:
					package = new McpeSetTime();
					package.Decode(buffer);
					return package;
				case 0xaa:
					package = new McpeSetHealth();
					package.Decode(buffer);
					return package;
				case 0xab:
					package = new McpeSetSpawnPosition();
					package.Decode(buffer);
					return package;
				case 0x87:
					package = new McpeStartGame();
					package.Decode(buffer);
					return package;
				case 0xba:
					package = new McpeFullChunkData();
					package.Decode(buffer);
					return package;
				case 0x95:
					package = new McpeMovePlayer();
					package.Decode(buffer);
					return package;
				case 0xb7:
					package = new McpeAdventureSettings();
					package.Decode(buffer);
					return package;
				case 0xb4:
					package = new McpeContainerSetContent();
					package.Decode(buffer);
					return package;
				case 0x85:
					package = new McpeMessage();
					package.Decode(buffer);
					return package;
				case 0xa7:
					package = new McpeEntityData();
					package.Decode(buffer);
					return package;
				case 0x89:
					package = new McpeAddPlayer();
					package.Decode(buffer);
					return package;
			}

			return null;
		}
	}

	public partial class ConnectedPing : Package
	{
		public long sendpingtime; // = null;

		public ConnectedPing()
		{
			Id = 0x00;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(sendpingtime);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			sendpingtime = ReadLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class UnconnectedPing : Package
	{
		public long pingId; // = null;
		public readonly byte[] offlineMessageDataId = new byte[]{ 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 }; // = { 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 };

		public UnconnectedPing()
		{
			Id = 0x01;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(pingId);
			Write(offlineMessageDataId);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			pingId = ReadLong();
			ReadBytes(offlineMessageDataId.Length);

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class ConnectedPong : Package
	{
		public long sendpingtime; // = null;
		public long sendpongtime; // = null;

		public ConnectedPong()
		{
			Id = 0x03;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(sendpingtime);
			Write(sendpongtime);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			sendpingtime = ReadLong();
			sendpongtime = ReadLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class Ack : Package
	{
		public short count; // = null;
		public byte onlyOneSequence; // = null;
		public little sequenceNumber; // = null;

		public Ack()
		{
			Id = 0xc0;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(count);
			Write(onlyOneSequence);
			Write(sequenceNumber);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			count = ReadShort();
			onlyOneSequence = ReadByte();
			sequenceNumber = ReadLittle();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class Nak : Package
	{
		public short count; // = null;
		public byte onlyOneSequence; // = null;
		public little sequenceNumber; // = null;

		public Nak()
		{
			Id = 0xa0;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(count);
			Write(onlyOneSequence);
			Write(sequenceNumber);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			count = ReadShort();
			onlyOneSequence = ReadByte();
			sequenceNumber = ReadLittle();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class UnconnectedPong : Package
	{
		public long pingId; // = null;
		public long serverId; // = null;
		public readonly byte[] offlineMessageDataId = new byte[]{ 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 }; // = { 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 };
		public string serverName; // = null;

		public UnconnectedPong()
		{
			Id = 0x1c;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(pingId);
			Write(serverId);
			Write(offlineMessageDataId);
			Write(serverName);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			pingId = ReadLong();
			serverId = ReadLong();
			ReadBytes(offlineMessageDataId.Length);
			serverName = ReadString();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class OpenConnectionRequest1 : Package
	{
		public readonly byte[] offlineMessageDataId = new byte[]{ 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 }; // = { 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 };
		public byte raknetProtocolVersion; // = null;

		public OpenConnectionRequest1()
		{
			Id = 0x05;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(offlineMessageDataId);
			Write(raknetProtocolVersion);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			ReadBytes(offlineMessageDataId.Length);
			raknetProtocolVersion = ReadByte();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class OpenConnectionReply1 : Package
	{
		public readonly byte[] offlineMessageDataId = new byte[]{ 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 }; // = { 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 };
		public long serverGuid; // = null;
		public byte serverHasSecurity; // = null;
		public short mtuSize; // = null;

		public OpenConnectionReply1()
		{
			Id = 0x06;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(offlineMessageDataId);
			Write(serverGuid);
			Write(serverHasSecurity);
			Write(mtuSize);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			ReadBytes(offlineMessageDataId.Length);
			serverGuid = ReadLong();
			serverHasSecurity = ReadByte();
			mtuSize = ReadShort();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class OpenConnectionRequest2 : Package
	{
		public readonly byte[] offlineMessageDataId = new byte[]{ 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 }; // = { 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 };
		public byte[] clientUdpPort; // = null;
		public short mtuSize; // = null;
		public long clientGuid; // = null;

		public OpenConnectionRequest2()
		{
			Id = 0x07;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(offlineMessageDataId);
			Write(clientUdpPort);
			Write(mtuSize);
			Write(clientGuid);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			ReadBytes(offlineMessageDataId.Length);
			clientUdpPort = ReadBytes(6);
			mtuSize = ReadShort();
			clientGuid = ReadLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class OpenConnectionReply2 : Package
	{
		public readonly byte[] offlineMessageDataId = new byte[]{ 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 }; // = { 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 };
		public long serverGuid; // = null;
		public short clientUdpPort; // = null;
		public short mtuSize; // = null;
		public byte doSecurity; // = null;

		public OpenConnectionReply2()
		{
			Id = 0x08;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(offlineMessageDataId);
			Write(serverGuid);
			Write(clientUdpPort);
			Write(mtuSize);
			Write(doSecurity);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			ReadBytes(offlineMessageDataId.Length);
			serverGuid = ReadLong();
			clientUdpPort = ReadShort();
			mtuSize = ReadShort();
			doSecurity = ReadByte();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class ConnectionRequest : Package
	{
		public long clientGuid; // = null;
		public long timestamp; // = null;
		public byte doSecurity; // = null;

		public ConnectionRequest()
		{
			Id = 0x09;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(clientGuid);
			Write(timestamp);
			Write(doSecurity);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			clientGuid = ReadLong();
			timestamp = ReadLong();
			doSecurity = ReadByte();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class ConnectionRequestAccepted : Package
	{
		public long clientSystemAddress; // = null;
		public long systemIndex; // = null;
		public long incomingTimestamp; // = null;
		public long serverTimestamp; // = null;

		public ConnectionRequestAccepted()
		{
			Id = 0x10;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(clientSystemAddress);
			Write(systemIndex);
			Write(incomingTimestamp);
			Write(serverTimestamp);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			clientSystemAddress = ReadLong();
			systemIndex = ReadLong();
			incomingTimestamp = ReadLong();
			serverTimestamp = ReadLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class NewIncomingConnection : Package
	{
		public int cookie; // = null;
		public byte doSecurity; // = null;
		public short port; // = null;
		public long session; // = null;
		public long session2; // = null;

		public NewIncomingConnection()
		{
			Id = 0x13;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(cookie);
			Write(doSecurity);
			Write(port);
			Write(session);
			Write(session2);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			cookie = ReadInt();
			doSecurity = ReadByte();
			port = ReadShort();
			session = ReadLong();
			session2 = ReadLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class McpeLogin : Package
	{
		public string username; // = null;
		public int protocol; // = null;
		public int protocol2; // = null;
		public int clientId; // = null;
		public string logindata; // = null;

		public McpeLogin()
		{
			Id = 0x82;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(username);
			Write(protocol);
			Write(protocol2);
			Write(clientId);
			Write(logindata);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			username = ReadString();
			protocol = ReadInt();
			protocol2 = ReadInt();
			clientId = ReadInt();
			logindata = ReadString();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class McpeLoginStatus : Package
	{
		public int status; // = null;

		public McpeLoginStatus()
		{
			Id = 0x83;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(status);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			status = ReadInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class McpeReady : Package
	{

		public McpeReady()
		{
			Id = 0x84;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class McpeSetTime : Package
	{
		public int time; // = null;
		public byte started; // = null;

		public McpeSetTime()
		{
			Id = 0x86;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(time);
			Write(started);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			time = ReadInt();
			started = ReadByte();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class McpeSetHealth : Package
	{
		public byte health; // = null;

		public McpeSetHealth()
		{
			Id = 0xaa;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(health);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			health = ReadByte();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class McpeSetSpawnPosition : Package
	{
		public int x; // = null;
		public int z; // = null;
		public byte y; // = null;

		public McpeSetSpawnPosition()
		{
			Id = 0xab;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(x);
			Write(z);
			Write(y);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			x = ReadInt();
			z = ReadInt();
			y = ReadByte();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class McpeStartGame : Package
	{
		public int seed; // = null;
		public int generator; // = null;
		public int gamemode; // = null;
		public int entityId; // = null;
		public int spawnX; // = null;
		public int spawnZ; // = null;
		public int spawnY; // = null;
		public float x; // = null;
		public float y; // = null;
		public float z; // = null;

		public McpeStartGame()
		{
			Id = 0x87;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(seed);
			Write(generator);
			Write(gamemode);
			Write(entityId);
			Write(spawnX);
			Write(spawnZ);
			Write(spawnY);
			Write(x);
			Write(y);
			Write(z);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			seed = ReadInt();
			generator = ReadInt();
			gamemode = ReadInt();
			entityId = ReadInt();
			spawnX = ReadInt();
			spawnZ = ReadInt();
			spawnY = ReadInt();
			x = ReadFloat();
			y = ReadFloat();
			z = ReadFloat();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class McpeFullChunkData : Package
	{
		public byte[] chunkData; // = null;

		public McpeFullChunkData()
		{
			Id = 0xba;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(chunkData);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			chunkData = ReadBytes(0);

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class McpeMovePlayer : Package
	{
		public int entityId; // = null;
		public float x; // = null;
		public float y; // = null;
		public float z; // = null;
		public float yaw; // = null;
		public float pitch; // = null;
		public float bodyYaw; // = null;
		public byte teleport; // = null;

		public McpeMovePlayer()
		{
			Id = 0x95;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(entityId);
			Write(x);
			Write(y);
			Write(z);
			Write(yaw);
			Write(pitch);
			Write(bodyYaw);
			Write(teleport);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			entityId = ReadInt();
			x = ReadFloat();
			y = ReadFloat();
			z = ReadFloat();
			yaw = ReadFloat();
			pitch = ReadFloat();
			bodyYaw = ReadFloat();
			teleport = ReadByte();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class McpeAdventureSettings : Package
	{
		public int flags; // = null;

		public McpeAdventureSettings()
		{
			Id = 0xb7;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(flags);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			flags = ReadInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class McpeContainerSetContent : Package
	{
		public byte windowId; // = null;
		public short slotCount; // = null;
		public byte[] slotData; // = null;
		public short hotbarCount; // = null;
		public byte[] hotbarData; // = null;

		public McpeContainerSetContent()
		{
			Id = 0xb4;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(windowId);
			Write(slotCount);
			Write(slotData);
			Write(hotbarCount);
			Write(hotbarData);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			windowId = ReadByte();
			slotCount = ReadShort();
			slotData = ReadBytes(0);
			hotbarCount = ReadShort();
			hotbarData = ReadBytes(0);

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class McpeMessage : Package
	{
		public string source; // = null;
		public string message; // = null;

		public McpeMessage()
		{
			Id = 0x85;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(source);
			Write(message);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			source = ReadString();
			message = ReadString();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class McpeEntityData : Package
	{
		public int x; // = null;
		public byte y; // = null;
		public int z; // = null;
		public byte[] namedtag; // = null;

		public McpeEntityData()
		{
			Id = 0xa7;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(x);
			Write(y);
			Write(z);
			Write(namedtag);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			x = ReadInt();
			y = ReadByte();
			z = ReadInt();
			namedtag = ReadBytes(0);

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

	public partial class McpeAddPlayer : Package
	{
		public long clientId; // = null;
		public string username; // = null;
		public int entityId; // = null;
		public float x; // = null;
		public float y; // = null;
		public float z; // = null;
		public byte yaw; // = null;
		public byte pitch; // = null;
		public short unknown1; // = null;
		public short unknown2; // = null;
		public byte[] metadata; // = null;

		public McpeAddPlayer()
		{
			Id = 0x89;
		}

		protected override void EncodePackage()
		{
			base.EncodePackage();

			BeforeEncode();

			Write(clientId);
			Write(username);
			Write(entityId);
			Write(x);
			Write(y);
			Write(z);
			Write(yaw);
			Write(pitch);
			Write(unknown1);
			Write(unknown2);
			Write(metadata);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePackage()
		{
			base.DecodePackage();

			BeforeDecode();

			clientId = ReadLong();
			username = ReadString();
			entityId = ReadInt();
			x = ReadFloat();
			y = ReadFloat();
			z = ReadFloat();
			yaw = ReadByte();
			pitch = ReadByte();
			unknown1 = ReadShort();
			unknown2 = ReadShort();
			metadata = ReadBytes(0);

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

	}

}

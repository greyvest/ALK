#include <iostream>
#include <string.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <arpa/inet.h>
#include <stdlib.h>
#include <unistd.h>
#define PORT 8080

using namespace std;


int main()
{
  //this is the server descriptor, we'll assign the server's socket to it
  int server_d;
  //this is value that we'll assign the new socket to after it connects to the server
  int new_socket;
  //this is the value that we'll set to equal whatever we read from the socket after it connects
  int valread;
  //This is going to be the socket structure, I think
  struct sockaddr_in address;
  //I don't know why we need this
  int opt = 1;
  //size of socket structure
  int addrlen = sizeof(address);
  //buffer to recieve data in, I think
  char buffer[1024] = {0};
  //message to print from server, I think
  string hello = "Hello from server";
  
  //creating socket for server, AF_INETT = IPV4, SOCK_STREAM = TCP, 0 = Let OS choose correct protocool
  if((server_d = socket(AF_INET, SOCK_STREAM, 0)) == 0){
    cout << "Serverside socket failed to create" << endl;
    return 1;
  }
  
  //attach server socket to a specified port
  if(setsockopt(server_d, SOL_SOCKET, SO_REUSEADDR | SO_REUSEPORT, &opt, sizeof(opt))){
    cout << "setsockopt" << endl;
    return 1;
  }

  //I th ink this sets the server socket structure to AF_INET, which is IPV4
  address.sin_family = AF_INET;
  //
  address.sin_addr.s_addr = INADDR_ANY;
  /*set server socket port. htons the htons() function converts values between host and network byte orders. There is a difference between big-endian and little-endian and network byte order depending on your machine and network protocol in use.*/
  address.sin_port = htons(PORT);

  //attach server socket to the port
  if(bind(server_d, (struct sockaddr *)&address, sizeof(address))<0){
    cout << "Bind failed" << endl;
    return 1;
  }
  cout << "Listening now " << endl;
  //set sever to listen
  if(listen(server_d, 3) < 0){
    cout << "Couldn't begin listening" << std::endl;
    return 1;
  }
  while(true){
    
    //when a new socket hits
    if((new_socket = accept(server_d, (struct sockaddr *)&address, (socklen_t*)&addrlen))<0)
      {
	cout << "Accept new socket failed" << endl;
	return 1;
      }

    //read val from newly accepted socket
    valread = read(new_socket, buffer, 1024);
    //print data recieved from client
    cout << buffer << endl;

  
    char tab2[1024];
    strcpy(tab2, hello.c_str());
    //send client data
    send(new_socket, tab2, strlen(tab2) , 0);
    //confirm that send operation finished
    cout << "Hello message sent to client" << endl;
    listen(server_d,3);
  }
  return 0;


}

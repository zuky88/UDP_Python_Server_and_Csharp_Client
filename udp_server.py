import socket

PORT = 50010
BUFSIZE = 1024

s = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
s.bind(('', PORT))

data = [0,1,2,3]

while True:
    d, address = s.recvfrom(BUFSIZE)
    print(d)
    if d.decode() == 'reqest':
        print('>address={0}, data={1}'.format(address, data))
        s.sendto(bytes(data),address)
        data[0] = data[1]
        data[1] += 1

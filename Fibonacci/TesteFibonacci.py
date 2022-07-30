import array as lista

valorAnt = 1
valorSoma = 1
valorProx = 1
listaResult = lista.array('i',[1])

print(valorAnt)
count = 1
while(count < 20):
    listaResult.append(valorSoma)
    #print(valorSoma)
    valorSoma = valorProx + valorAnt
    valorAnt = valorProx
    valorProx = valorSoma
    count += 1
    
print(listaResult)


#print("Sequencia de Fibonacci: \n")
#anterior = 0
#proxima = 1
#soma = 1

#for n in range(0,21):
#    print(anterior)
#    soma = proxima + anterior
#    anterior = proxima
#    proxima = soma








# Prints all letters except 'e' and 's'
#i = 0
#a = 'geeksforgeeks'

#while i < len(a):
#	if a[i] == 'e' or a[i] == 's':
#		i += 1
#		continue
#		
#	print('Current Letter :', a[i])
#	i += 1

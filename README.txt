Grupo nº: 7

Nome: José Cavalheiro
Número: 64804

Nome: Alberto Carvalho
Número: 66933

1 - Local onde se encontra cada orquestração:

	A orquestração E-commerce encontra-se na pasta E-commerce.
	A orquestração Inventory encontra-se na pasta Inventory.
	A orquestração Supplier encontra-se na pasta Supplier.
	A orquestração Production encontra-se na pasta Production.

2 - Local onde se encontram os web services

	O web service Bank encontra-se na pasta BankService, incluindo os ficheiros que se encontravam originalnalmente na pasta C:\inetpub\wwwroot\Bank.
	O web service Inventory encontra-se na pasta InventoryService, incluindo os ficheiros que se encontravam originalnalmente na pasta 	C:\inetpub\wwwroot\Inventory.

3 - Informação acerca dos scripts SQL

	A pasta SQL Scripts contem os scripts usados para criar a tabela Inventory (no SQLServer), carregar os dados e criar as stored procedures.

4 - Informação acerca das dependências das orquestrações e esquemas partilhados

	A orquestração E-Commerce usa alguns xml schemas das orquestrações Inventory (CheckComponent, ComponentAvailable), Production (AssembleComputer, ComputerAssembled), e Supplier (ShippingNotice, ShippingOrder).
	A orquestração Inventory usa alguns xml schemas da orquestração Supplier (OrderComponent, ShippingNotice).

5 - Informação acerca das queues

	O sistema Shipping tem uma queue de entrada (shipping_input_queue) que recebe mensagens do tipo ShippingOrder dos sistemas E-commerce e Supplier. Este sistema tem também duas queues de saída (ecommerce_shipping_output_queue e supplier_shipping_output_queue) onde são colacadas as mensagens do tipo shippingNotice.

6 - Informação acerca das correlações

	6.1 - Correlações relativas à orquestração E-Commerce

		Existe uma correlação que se inicia na mensagem do tipo CheckComponent e termina na mensagem do tipo ComponentAvailable. 
		O identificador da correlação é o valor do campo orderNumber somado com o indice da iteração do ciclo (1,2,3 etc..)

		Existe uma correlação que se inicia na mensagem do tipo AssembleComputer e termina na mensagem do tipo ComputerAssembled
		O identificador da correlação é o valor do campo OrderNumber da mensagem AssembleComputer

		Existe uma correlação que se inicia na mensagem do tipo ShippingOrder e termina na mensagem do tipo ShippingNotice
		O identificador da correlação é o valor do campo OrderNumber da mensagem ShippingOrder

	6.2 - Correlações relativas à orquestração Inventory

		Existe uma correlação que se inicia na mensagem do tipo OrderComponent e termina na mensagem do tipo ShippingNotice
		O identificador da correlação é o timestamp relativo ao momento em que a mensagem OrderComponent é criada

	6.3 - Correlações relativas à orquestração Supplier

		Existe uma correlação que se inicia na mensagem do tipo ShippingOrder e termina na mensagem do tipo ShippingNotice
		O identificador da correlação é o campo PurchaseNumber da mensagem ShippingOrder

## Calculadora em C#

Este é um projeto simples de uma calculadora feita em C# utilizando Windows Forms desenvolvido no curso técnico em desenvolvimento de sistemas no senac de Pindamonhamgaba.



## Funcionalidades

A calculadora permite a digitação de números por botões e pelo teclado, suporta operações básicas de adição, subtração, multiplicação e divisão. O sistema trata as entradas para evitar que operadores inválidos sejam inseridos no início da expressão ou duplicados seguidos, além de substituir automaticamente os operadores digitados via teclado para uma melhor experiência (* por x e / por ÷), Possui um botão para limpar a tela, um botão de igual para calcular o resultado, previne divisões por zero, permite que o cálculo seja efetuado ao pressionar a tecla Enter.



## Estrutura do Código
O formulário principal da calculadora contém os botões de interação e métodos sendo eles Btnlimpar_Click (limpa o TextBox), Numero_Click (adiciona números), Operador_Click (adiciona/substitui operadores), Btnigual_Click (calcula o resultado), TxtbTela_KeyPress (valida entrada), TxtbTela_TextChanged (posiciona o cursor) e TxtbTela_KeyDown (calcula ao pressionar Enter). A manipulação de eventos usa o parâmetro sender para identificar qual botão foi clicado, simplificando o código. A lógica controla a entrada de números e operadores, limpa o visor, calcula resultados e mantém o cursor no final do texto. 
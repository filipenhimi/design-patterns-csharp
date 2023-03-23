using Bridge;

JanelaAbstrata janela = new JanelaDialogo(new JanelaWindows());
janela.desenhar();

janela = new JanelaDialogo(new JanelaLinux());
janela.desenhar();
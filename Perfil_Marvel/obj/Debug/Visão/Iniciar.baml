   M S B A M L   `   `   `  ����H  DPerfil_Marvel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Perfil_MarvelPerfil_Marvel  5   	   (    "Perfil_Marvel.Visão.IniciarWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Perfil_Marvel     5   	     � Title$  Iniciar Partida��5   
   $	��720��6"   $
��1280��6/    � 
ResizeMode$ CanMinimize=�6<    � Cursor$ Arrow��5	   	   $��18(�6   ��5
      �� 5   
    �� ImageSource$ img/sistema/bg.png��6    �� Opacity$	 0.5Q�66   .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��6* �6   �� 5      $��2* �6   �� 5      $��1* �6   .+�5   
   �� -   5        $��	btnVoltar��5   .   $��0��6   $��0��6   $��55��6?   $��55��6K   
����������	#FFED1A23$��
REVOLUTION)�6�   $��Center=�6�   $��2q�6�   
�������$��Center=�6�   .��5      �� .+�5      �� $��30��6   $ ��img/sistema/left-arrow.png��6#   5      5      � 5"   
   $��0��6   $��1��6   $��2��6,   .+�5#      �� $ ��img/sistema/logomarvel.png��6   $��Center=�68   $��Center=�6U   5$      5%      � 5)   
   $��1��6   $��1��6    5*      �� 5+      $��2* �6    �� 5,      $��1* �6    �� 5-      $��1* �6    �� 5.      $��1* �6    �� 5/      $��2* �6    .+�52      �� $��0��6   $#��Escolha o numero de jogadores��6!   
����������	#FFED1A23$��
REVOLUTION)�6s   $��Center=�6�   $��Center=�6�   $��10q�6�   $��2q�6�   
�������6�   �� 54      $��1��6   $��3��6%   $	��180��66   $	��160��6B   
�������$��Center=�6\   $��Center=�6y   �� 55      $��1��6   $��3��6%   $	��176��66   $	��156��6B   ���	#FFED1A23$��Center=�6`   $��Center=�6}    K� ZIndex$ 1��6�   	� 57      -   5        $��rb2Jogadores��57      $ 2��6.   $��1��6?    	� 	GroupName$
 nJog��6L   $��2 jogadores��6]   	 d� 	IsChecked$
	 TrueY�6s   
�������$��Raleway SemiBold)�6�   $��18(�6�   $��Center=�6�   $��Center=�6�   	� 58      -   5        $��rb3Jogadores��58      $ 2��6.   $��2��6?   $
 nJog��6L   $��3 jogadores��6]   
�������$��Raleway SemiBold)�6�   $��18(�6�   $��Center=�6�   $��Center=�6�   	� 59      -   5        $��rb4Jogadores��59      $ 2��6.   $��3��6?   $
 nJog��6L   $��4 jogadores��6]   
�������$��Raleway SemiBold)�6�   $��18(�6�   $��Center=�6�   $��Center=�6�   �� 5;      -   5        $��btnConfNumJogadores��5;   "   $��4��6   $��	Confirmar��6=   $��45��6Q   $	��270��6]   $��Center=�6i   $��10q�6�   ���	#FFED1A23$��
REVOLUTION)�6�   $��Center=�6�   
�������
�������$��10q�6  $��2q�6  6$  5<      � 5?   
   $��1��6   $��2��6    5@      �� 5A      $��2* �6    �� 5B      $��1* �6    �� 5C      $��1* �6    �� 5D      $��1* �6    �� 5E      $��1* �6    �� 5F      $��1* �6    .+�5I      �� $��0��6   $!��Defina o nome dos jogadores��6!   
����������	#FFED1A23$��
REVOLUTION)�6q   $��Center=�6�   $��Center=�6�   $��10q�6�   $��2q�6�   
�������6�   �� 5K      -   5        $��txtJog1��5K      $��1��6%   $��Center=�62   $��Center=�6M   $	��250��6j   $��Center=�6v   $��5q�6�   ���	#FFED1A23
 �� SelectionBrush
 �	#FFC80023
�������
�������$��Raleway SemiBold)�6�   $��2q�6  $��Primeiro jogador��6/   �� 	UndoLimit$ 30��6G  $��16(�6V  $��35��6d  {�.  6p  �� 5L      -   5        $��txtJog2��5L      $��2��6%   $��Center=�62   $��Center=�6M   $	��250��6j   $��Center=�6v   $��5q�6�   ���	#FFED1A23
 �	#FFC80023
�������
�������$��Raleway SemiBold)�6�   $��2q�6  $��Segundo jogador��6/  $ 30��6F  $��16(�6U  $��35��6c  {�.  6o  �� 5M      -   5        $��txtJog3��5M      $��3��6%   $��Center=�62   $��Center=�6M   $	��250��6j   $��Center=�6v   $��5q�6�   ���	#FFED1A23
 �	#FFC80023
�������
�������$��Raleway SemiBold)�6�   $��2q�6  $��Terceiro jogador��6/  $ 30��6G  $��16(�6V  $��35��6d  {�.  6p  �� 5N      -	   5        $��txtJog4��5N      $��4��6%   $��Center=�62   $��Center=�6M   $	��250��6j   $��Center=�6v   $��5q�6�   ���	#FFED1A23
 �	#FFC80023
�������
�������$��Raleway SemiBold)�6�   $��2q�6  $��Quarto jogador��6/  $ 30��6E  $��16(�6T  $��35��6b  {�.  6n  5O      � 5R   
   $��2��6   $��1��6   $��2��6,   .+�5S      �� -
   5        $��btnJogar��5S   "   $��1��6   $��Jogar��62   $��45��6B   $	��270��6N   $��Center=�6Z   $��10q�6w   ���	#FFED1A23$��
REVOLUTION)�6�   $��Center=�6�   
�������
�������$��10q�6�   $��2q�6  6  5T      5V      5W      
   M S B A M L   `   `   `  ����E  AWpfEjemplo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfEjemplo
WpfEjemplo  5   	       WpfEjemplo.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfEjemplo     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��900��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      $��2* �6   �� 5      $��6* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5      $��2��6%   $
��Left=�65   $��	10,10,0,0q�6P   $	��Top=�6c   $	��449��6{   $	��575��6�   $��4��6�   ��6�   �� *usuariosResgistrados+�� 5   
   -   5         ��Name$ 	textBlock��5      $
��Left=�6'   $��	11,61,0,0q�6B   $
��Wrap=�6U   $��Usuario��6i   $	��Top=�6x   �� 5   
   -   5         ��Name$ textBox��5      $��1��6I   $
��Left=�6Y   $��23��6t   $��	10,54,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6#   �� *nuevoUsuario.Usuario+6�   �� 5   
   -   5        $ 
textBlock1��5      $
��Left=�6(   $��	10,91,0,0q�6C   $
��Wrap=�6V   $��Password��6j   $	��Top=�6z   �� 5   
   -   5        $ textBox1��5      $��1��6M   $
��Left=�6]   $��23��6x   $��	10,84,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6$   �� *nuevoUsuario.Contrasena+6�   �� 5   
   -   5        $ 
textBlock2��5      $
��Left=�6(   $��	10,24,0,0q�6C   $��1��6V   $
��Wrap=�6c   $��Responsable��6w   $	��Top=�6�   �� 5   
   -   5        $ textBox2��5      $��1��6N   $
��Left=�6^   $��23��6y   $��	10,17,0,0q�6�   $��1��6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6$   �� *nuevoUsuario.Responsable+6�   �� 5   
   -   5        $ 
textBlock3��5      $
��Left=�6(   $��	10,64,0,0q�6C   $��1��6V   $
��Wrap=�6c   $��Rol Funcional��6w   $	��Top=�6�   �� 5   
   -	   5         ��Name$ button��5      $��Agregar Usuario��6!   $��1��6;   $
��Left=�6K   $��	10,27,0,0q�6f   $��2��6y   $	��Top=�6�   $	��120��6�   $��34��6�   6�   5      5      
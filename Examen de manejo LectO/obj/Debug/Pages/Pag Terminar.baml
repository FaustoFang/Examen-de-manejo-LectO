   M S B A M L   `   `   `  ����Q  MExamen de manejo LectO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Examen_de_manejo_LectO.PagesExamen_de_manejo_LectO.Pages  5      /    )Examen_de_manejo_LectO.Pages.Pag_Terminar   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Examen_de_manejo_LectO.Pages     5        N� Title$  Pag_Terminar��5	       N� 
Background
 ����� N� 
FontFamily$ OpenDyslexic)�6/   .��5      � .+�5   
   � $	��150��6   $	��Top=�6   ���	#FF6491E9.+�5      �� $��Center=�6   $��Center=�63   $��50(�6P   Examen de conducir6r   5      � 5   
   $��	0,150,0,0q�6    � RowDefinitions 5      �� 5      �� 5      �� 5      $
��0.7* �6     � ColumnDefinitions 5      �� 5      $
��0.4* �6#   �� 5      $
��0.1* �6#   �� 5      $��1* �6#   �� 5      $
��0.1* �6#   �� 5      $
��0.4* �6#   .+�5      � $��0��6   $��1��6    $��3��60   $
��auto��6D   $
��auto��6R   $��Center=�6_   $��Center=�6|   .+�5      (� .��5      ��  �� Orientation$ Vertical=�6!   .+�5       ��  �� TextAlignment$ Center=�6$   $��0,0,0,2q�6;   0.¿Está seguro/a que desea terminar el examen?6z   �� 5!      $ Center=�6$   $��0,5,0,0q�6;   75Verifique que haya ingresado sus datos correctamente.6�   5"      5#      5$      (� 5&      $��1��6   $��2��6#   .��5'      �� $ Vertical=�6   $��Center=�64   $��Center=�6Q   .+�5(      �  5)      �� 5*      61   �� 5+      61   .+�5-      �� $��0��6$   $��1��64   $��Center=�6H   $
��Left=�6c   $��28(�6~   ���	#FF5F5E5ENombre y apellido:6�   �� 5.      -   5         ��Name$ txtNombreApellido��5.   "   $��1��6=   $��1��6M   $��38��6a   $��24(�6m   $��Center=�6{   6�   50      � 51      $	��700��6   $	��120��6'    52      �� 53      61   �� 54      61   .+�56      �� $��0��6$   $��1��64   $��Center=�6H   $
��Left=�6c   $��28(�6~   ���	#FF5F5E5E
Documento:6�   �� 57      -   5        $ txtDocumento��57   "   $��1��68   $��1��6H   $��38��6\   $��24(�6h   $��Center=�6v   6�   58      59      5:      �� 5;      $��2��6   $��2��6&   $ 
Horizontal=�66   $��Center=�6O   $��Center=�6j   .+�5<      �� -   5         ��Name$ btnVolverAtras��5<      $	��100��61   $	��300��6>   ���	#FF6BDDED$��0q�6a   	 � Cursor$
	 Hand��6u   $��0,0,30,0q�6�   .��5=      �� $ 
Horizontal=�6!   .+�5>      �� $@��:/Examen de manejo LectO;component/Resources/FlechaLeft.png��6    $��0,0,5,0q�6d   $��50��6u   
 J� Opacity$	
 0.7Q�6�   6�   �� 5?      $��Center=�6$   $��32(�6?   $��5,0,0,0q�6M   Volver atrás6l   5@       � 	Resources 5A       �� 
TargetType �� Property �� Value��%^   '��       �� 5B      " ��6    .�5C      ��  �@��CornerRadius$ 7��6=   5D      5E      5F      �� 5G      -   5        $ btnTerminar��5G      $	��100��6.   $	��300��6;   ���#B2C5F5$��0q�6\   $
	 Hand��6p   $��36(�6~   $��30,0,0,0q�6�   .��5H      �� $ 
Horizontal=�6!   .+�5I      �� $��Center=�6$   $��32(�6?   $��0,0,5,0q�6M   
Terminar6h   �� 5J      $>��8/Examen de manejo LectO;component/Resources/Terminar.png��6    $��5,0,0,0q�6b   $��70��6s   $	
 0.7Q�6~   6�   5K       5L      ��%^   '��       �� 5M      " ��6    .�5N      ��  �@��CornerRadius$ 7��6=   5O      5P      5Q      5R      5S      5T      5U      
   M S B A M L   `   `   `  ����G  CCrud_Alumnos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Crud_AlumnosCrud_Alumnos  5   	       Crud_Alumnos.InsertWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Crud_Alumnos     5   	     � Title$  InsertWindow��5   	   $	��450��6   $	��800��6+   .��5	      � .+�5
   
   �� -   5         ��Name$ 	txtCarnet��5
      $
��Left=�6%   $��
397,95,0,0q�6@    �� TextWrapping$
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��120��6�   �� 5   
   $
��Left=�6   $��
311,95,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   �� 6p    � Language$ es-gt�6t   $�Carnet��6�   �� 6�   $�:��6�   6�   �� 5   
   -   5        $ 	txtNombre��5      $
��Left=�6%   $��397,153,0,0q�6@   $
 Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��120��6�   �� 5   
   $
��Left=�6   $��311,153,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   �� 6q   $ es-gt�6u   $�Nombre��6�   �� 6�   $�:��6�   6�   �� 5   
   -   5        $ txtTelefono��5      $
��Left=�6'   $��397,217,0,0q�6B   $
 Wrap=�6W   $�� ��6k   $	��Top=�6s   $	��120��6�   �� 5   
   $
��Left=�6   $��311,217,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   �� 6q   $ es-gt�6u   $�Telefono��6�   �� 6�   $�:��6�   6�   �� 5   
   -   5        $ txtGrado��5      $
��Left=�6$   $��397,276,0,0q�6?   $
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��120��6�   �� 5   
   $
��Left=�6   $��311,276,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   �� 6q   $ es-gt�6u   $�Grado��6�   �� 6�   $�:��6�   6�   �� 5   
   -   5         ��Name$ btnCrear��5      $��Guardar��6#   $
��Left=�65   $��397,370,0,0q�6P   $	��Top=�6e    J� RenderTransformOrigin$ 
0.539,2.35&�6�   �� 5   
   -   5        $ txtIdUsario��5      $
��Left=�6'   $��
397,51,0,0q�6B   $
 Wrap=�6V   $�� ��6j   $	��Top=�6r   $	��120��6�   �� 5   
   $
��Left=�6   $��
311,51,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   �� 6p   $�Id��6t   �� 6�   $ es-gt�6�   $�Usuario��6�   �� 6�   $�:��6�   6�   �� 5   
   $
��Left=�6   $��311,328,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   �� 6q   $ es-gt�6u   $�Usuario��6�   �� 6�   $�:��6�   6�   �� 5   
   -   5         ��Name$ 
cboUsuario��5       �� DisplayMemberPath$ Nombre��5       �� SelectedValuePath$ Id��5      $
��Left=�5      $��397,322,0,0q�6*   $	��Top=�6?   $	��120��6W   	 �� SelectedValue	 5   '   �� *	Usuario+
 �� Mode$
 OneWay=�5   W   5      5      
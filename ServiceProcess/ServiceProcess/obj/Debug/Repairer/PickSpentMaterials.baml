   M S B A M L   `   `   `  ����I  EServiceProcess, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ServiceProcessServiceProcess  5   	   '    !ServiceProcess.PickSpentMaterials   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ServiceProcess     5   	     � WindowStartupLocation$  CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y    � Title$ PickSpentMaterials��5   	   $	��710��6$   $	��800��61   .��5	      � .+�5
   
   o� $
��Left=�6   $��23��6*   $��	10,10,0,0q�66   $	��Top=�6I   $	��772��6a   .@�5      �� $
��Left=�6   $	��Top=�60   $��26��6H   
�������
�������.��5      �� $1��+/images/chimney-home-icon-transparent-1.png��6   $
��Fill=�6M   $��17��6\   $��18��6h   5      �� 5      -   5        $��Profile��5      $
��Left=�6'   $	��Top=�6B   $	��120��6Z   6f   �� 5      -   5        $��Search clients��5      $
��Left=�6.   $	��Top=�6I   $	��120��6a   6m   5      �� 5   
   $��Search for materials��6   $
��Left=�6/   $��	10,38,0,0q�6J   $	��Top=�6]   $��30(�6u   �� 5   
   -   5         ��Name$ tb_for_search��5      $
��Left=�6)   $��30��6D   $��	18,93,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��330��6�   $��20(�6�   �� 5   
   -   5        $��Search��5      $
��Left=�6"   $��
538,93,0,0q�6=   $	��Top=�6Q   $	��130��6i   $��30��6u   $��20(�6�   ���	#FF66B5F26�   �� 5   
   -   5         ��Name$ cb_criteria��5      $
��Left=�6(   $��
363,93,0,0q�6C   $	��Top=�6W   $	��161��6o   $��30��6{   $��20(�6�   .@�5      �� .��6   Name6!   5      �� 5   
   -   5         ��Name$ lb_picked_materials��5      $
��Left=�6/   $	��270��6J   $��513,190,0,0q�6W   $	��Top=�6l   $	��255��6�   $��20(�6�   ���	#FFC7E2F76�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dg_materials��5      $
��Left=�6)   $	��416��6D   $��
18,169,0,0q�6Q   $	��Top=�6e   $	��473��6}      
IsReadOnly . $��20(�6�   ���	#FFC7E2F76�   �� 5   
   $��Price :��6   $
��Left=�6"   $��511,484,0,0q�6=   $	��Top=�6R   $��20(�6j   �� 5   
   -   5        $ tb_price��5      $
��Left=�6$   $��30��6?   $��579,488,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��189��6�   $��20(�6�   �� 5   
   -	   5        $
��Done��5      $
��Left=�6    $��513,545,0,0q�6;   $	��Top=�6P   $	��255��6h   $��40��6t   $��20(�6�   ���	#FF66B5F26�   �� 5   
   -
   5        $��Clear��5      $
��Left=�6!   $��513,608,0,0q�6<   $	��Top=�6Q   $	��255��6i   $��40��6u   $��20(�6�   ���	#FF66B5F26�   �� 5   
   -   5        $
��Pick��5      $
��Left=�6    $��
18,608,0,0q�6;   $	��Top=�6O   $	��473��6g   $��40��6s   $��20(�6   ���	#FF66B5F26�   �� 5   
   $��Selected materials :��6   $
��Left=�6/   $��508,154,0,0q�6J   $	��Top=�6_   $��20(�6w   5      5       
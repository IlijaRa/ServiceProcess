   M S B A M L   `   `   `  ����I  EServiceProcess, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ServiceProcessServiceProcess  5   	   (    "ServiceProcess.FindClient_Repairer   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ServiceProcess     5   	     � WindowStartupLocation$  CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y    � Title$ FindClient_Repairer��5   	   $	��710��6%   $	��800��62   .��5	      � .+�5
   
   o� $
��Left=�6   $��23��6*   $��	10,10,0,0q�66   $	��Top=�6I   $	��772��6a   .@�5      �� $
��Left=�6   $	��Top=�60   $��26��6H   
�������
�������.��5      �� $1��+/images/chimney-home-icon-transparent-1.png��6   $
��Fill=�6M   $��17��6\   $��18��6h   5      �� 5      -   5        $��Profile��5      $
��Left=�6'   $	��Top=�6B   $	��120��6Z   6f   �� 5      -   5        $��Search clients��5      $
��Left=�6.   $	��Top=�6I   $	��120��6a   ���	#FF66B5F26�   5      �� 5   
   $��Find a client��6   $
��Left=�6(   $��	10,38,0,0q�6C   $	��Top=�6V   $��30(�6n   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
dg_clients��5      $
��Left=�6'   $	��433��6B   $��
18,156,0,0q�6O   $	��Top=�6c   $	��757��6{      GridLinesVisibility$ Vertical=�6�   $��20(�6�      
IsReadOnly . ���	#FFC7E2F76�   �� 5   
   -   5         ��Name$ tb_for_search��5      $
��Left=�6)   $��30��6D   $��	18,93,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��330��6�   $��20(�6�   �� 5   
   -   5        $��Search��5      $
��Left=�6"   $��
538,93,0,0q�6=   $	��Top=�6Q   $	��130��6i   $��30��6u   $��20(�6�   ���	#FF66B5F26�   �� 5   
   -   5         ��Name$ cb_criteria��5      $
��Left=�6(   $��
363,93,0,0q�6C   $	��Top=�6W   $	��161��6o   $��30��6{   $��20(�6�   .@�5      �� .��6   Clients name6)   �� 5      .��6   Clients surname6,   �� 5      .��6   Clients email6*   5      �� 5   
   -   5        $��Send a message��5      $
��Left=�6*   $��300,616,0,0q�6E   $	��Top=�6Z   $	��200��6r   $��30��6~   $��20(�6�   ���	#FF66B5F26�   5      5      
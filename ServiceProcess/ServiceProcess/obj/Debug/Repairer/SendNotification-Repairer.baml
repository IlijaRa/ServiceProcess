   M S B A M L   `   `   `  ����I  EServiceProcess, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ServiceProcessServiceProcess  5   	   .    (ServiceProcess.SendNotification_Repairer   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ServiceProcess     5   	     � WindowStartupLocation$  CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y    � Title$ SendNotification_Repairer��5   	   $	��710��6+   $	��800��68   .��5	      �  � RowDefinitions 5
   
   �� 5      .+�5   
   o� $
��Left=�6   $��23��6*   $��	10,10,0,0q�66   $	��Top=�6I   $	��772��6a   .@�5      �� $
��Left=�6   $	��Top=�60   $��26��6H   
�������
�������.��5      �� $1��+/images/chimney-home-icon-transparent-1.png��6   $
��Fill=�6M   $��17��6\   $��18��6h   5      �� 5      -   5        $��Profile��5      $
��Left=�6'   $	��Top=�6B   $	��120��6Z   6f   �� 5      -   5        $��Search clients��5      $
��Left=�6.   $	��Top=�6I   $	��120��6a   6m   5      �� 5   
   $*��$Send notification to 'Main repairer'��6   $
��Left=�6?   $��
138,57,0,0q�6Z   $	��Top=�6n   $��30(�6�   �� 5   
   $��611,61,133,570q�6   $!��/images/Image4_colored2.png��6(   $
��Fill=�6M   �� 5   
   $4��.This message will be sent to the Main repairer��6   $
��Left=�6I   $��
222,98,0,0q�6d   $	��Top=�6x   $��15(�6�   �� 5   
   -   5         ��Name$ tb_to��5      $
��Left=�6!   $��30��6<   $��248,149,0,0q�6H    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��388��6�   $��20(�6�   {�.  ���	#FFC7E2F76�   �� 5   
   -   5        $ 
tb_subject��5      $
��Left=�6&   $��30��6A   $��248,195,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��388��6�   $��20(�6�   �� 5   
   $
��To :��6   $
��Left=�6   $��154,146,0,0q�6:   $	��Top=�6O   $��20(�6g   $��50��6v   �� 5   
   $��	Subject :��6   $
��Left=�6$   $��154,192,0,0q�6?   $	��Top=�6T   $��20(�6l   $	��108��6{   �� 5   
   $��	Message :��6   $
��Left=�6$   $��154,234,0,0q�6?   $	��Top=�6T   $��20(�6l   $	��124��6{   �� 5   
   -   5        $ 
tb_message��5      $
��Left=�6&   $	��276��6A   $��248,241,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��388��6�   $��20(�6�    �� AcceptsReturn . 6�   �� 5   
   -   5        $
��Send��5      $
��Left=�6    $��290,594,0,0q�6;   $	��Top=�6P   $	��100��6h   $��30��6t   $��20(�6�   ���	#FF66B5F26�   �� 5   
   -   5        $��Go back��5      $
��Left=�6#   $��412,594,0,0q�6>   $	��Top=�6S   $	��100��6k   $��30��6w   $��20(�6�   ���	#FF66B5F26�   �� 5   
   $��Bill :��6   $
��Left=�6!   $��154,522,0,0q�6<   $	��Top=�6Q   $��20(�6i   $��50��6x   �� 5    
   -   5         ��Name$ cb_choose_bill��5       $
��Left=�6+   $��248,525,0,0q�6F   $	��Top=�6[   $	��388��6s   $��30��6   $��20(�6�   5!      5"      
   M S B A M L   `   `   `  ����K  GPayment_terminal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Payment_terminalPayment_terminal  5   	       Payment_terminal.Video   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Payment_terminal     5   	     � Title$   ��5   	    � WindowState$ 	Maximized=�6    � WindowStyle$
 None=�6*    � 	Resources 5	         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 TerminalStyle	 �� 
TargetType
 �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName��%<  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 �� 5
   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   "	 ��6&   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5        � ��# � ��6+   �� 5!       � ��$ 1q�60   �� 5"       � ��$ Center=�6;   �� 5#       � ��$ Center=�69   �� 5$       � ��$ 1q�6(   �� 5%       � �� 5&      �� 5'      "
 ��6&   .R�5(      �� $ border��6!   #��z��61   #��z��6]   #��z��6�    . ._�5)      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5*       5+      P� 5,       �@��IsDefaulted . . �5-   "   �� $ border��6@   # � ��6T    � ��5.      P� 5/       �@J�IsMouseOver . . �50   "   �� $ border��6?   8   � ��6S   �� 51   "   $ border��6@   8   � ��6T   52      P� 53       � �� . . �54   "   �� $ border��6?   8   � ��6S   �� 55   "   $ border��6@   8   � ��6T   56      P� 57       � {� .  . �58   "   �� $ border��6?   8   � ��6S   �� 59   "   $ border��6@   8   � ��6T   �� 5:   "   $ contentPresenter��6K   8 	  � ��6i   5;      5=      5?      5@      5A      .��5C      �  J� RenderTransformOrigin$ 0.503,0.486&�6    � ColumnDefinitions 5D   
   �� 5E      ��5G   
   �� 5H       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5I      �  � Color$ 	#FF04305B��6    � Offset$ 0Q�61   � 5J      # � ��6   $ 0.971Q�6c   5K       � RowDefinitions 5M   
   �� 5N      .+�5P   
   F� ����    ��E	���	#FF4D151C$
��Left=�6.   $��
0,87,0,355q�6I    �� Stretch$
 Fill=�6]   
���   �$��1��6{   �� 5Q   
   -   5         ��Name$ label��5Q      $��0,10,0,0q�6   $��18.667(�61   $��
Wide Latin)�6C   ���	#FFCF3434$��Right=�6r   $	��131��6�   $��38��6�   $	��Top=�6�   F� 5R   
   ���Ѐ��*@��		$��Right=�6   $��1��6;   $��
0,161,41,0q�6F   $
 Fill=�6Z   
���   �$	��Top=�6x   $��1��6�   �� 5S   
   
���   �$��1q�6%   $��20��69   $��Bottom=�6E   
�������6`   �� 5T   
   -   5        $ label_number��5T      $5��/Тех.Поддержка: +375-29-1234567 Vel.��6&   $��Center=�6T   $��235,0,257,0q�6x   $��Swis721 Hv BT)�6�   $��24��6�   $��Bottom=�6�   ��6�   Z� 6�   9� 5U   
   -   5         9�Name$ expander_ads��5U      $��Реклама��6)   $
��Left=�6:   $ 0.5,0.5&�6U    9� ExpandDirection$ Right=�6u   $��Times New Roman)�6�   $��20(�6�   $
��Bold"�6�   ���	#FFAFDE33$	��106��6�   $	��Top=�6�   $	��444��6  .��5V      �� -   5         ��Name$ ImgAds��5V      $��joy.png��6$   $��	0,0,0,-35q�65   $	��406��6H   5X      5Y      �� 5Z   
   -   5         ��Name$ button_prev��5Z   7     InformButton#��[ 6   $��На главную��6L   $
��Left=�6a   $	��160��6|   $��	10,0,0,30q�6�   $��45��6�   $��Bottom=�6�   6�   r� 5[   
   -   5         r�Name$ mediaElement��5[      $	��389��6-   $��6,51,6,0q�6:   $	��Top=�6L    r� Source$% res/Video_2016-06-20_074240.wmv?�6d     r� LoadedBehavior$  Manual=�6�   5]      5^      
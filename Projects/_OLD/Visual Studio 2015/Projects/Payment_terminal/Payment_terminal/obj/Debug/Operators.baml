   M S B A M L   `   `   `  ����K  GPayment_terminal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Payment_terminalPayment_terminal  5   	        Payment_terminal.Operators   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Payment_terminal     5   	     � Title$   ��5   	    � WindowState$ 	Maximized=�6    � WindowStyle$
 None=�6*   .��5	      �  J� RenderTransformOrigin$ 0.503,0.486&�6    � ColumnDefinitions 5
   
   �� 5       � RowDefinitions 5   
   �� 5      ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF04305B��6   	 � Offset$	 0Q�61   � 5      # � ��6   $	 0.971Q�6c   5      .+�5   
   �� ���	#FF64E46A$��64��6%   $��	25,58,0,0q�61   
���   �$	��Top=�6S   
 �� StrokeDashCap$
 Round=�6k    �� RadiusY$
 54.5��6�    �� RadiusX$
 54.5��6�    J� Opacity$	 0.5Q�6�   $
��Left=�6�   $	��282��6�   �� 5   
   ���	#FFF4F4F5$��33��6%   $��	74,74,0,0q�61   
���   �$	��Top=�6S   $
��Left=�6k   $	��185��6�   �� 5   
   -   5         ��Name$ button_prev��5   7      InformButton#��[  6   $��На главную��6L   $
��Left=�6a   $	��160��6|   $��	10,0,0,10q�6�   $��45��6�   $��Bottom=�6�   9� 5   
   -   5         9�Name$ expander_ads��5      $��Реклама��6)   $��Right=�6:   $ 0.5,0.5&�6V    9� ExpandDirection$
 Left=�6v   $��Times New Roman)�6�   $��20(�6�   $
��Bold"�6�   ���	#FFAFDE33 9� 
IsExpanded . $��50��6�   $��Bottom=�6�   .��5      �� -   5         ��Name$ ImgAds��5      $��joy.png��6$   5      �� 5   
   -   5         ��Name$ label1_Copy14��5      $*��$Выберите оператора:��6'   $
��Left=�6E   $��	74,74,0,0q�6`   $	��Top=�6s   $��16(�6�   $��33��6�   $	��190��6�   � 5   
   $��20,202,20,0q�6   $	��162��6$   $	��Top=�61    5      �� 5       $��1* �6#   �� 5!      $��1* �6#   �� 5"      $��1* �6#    5$      �� 5%      $��1* �6    .+�5'      �� -   5        $ 
buttonLife��5'      $��10q�6)   $��0��65   ��5(      �� 5)       �� ImageSource$ res/image.png��6!   5+      �� 5,      -   5        $ buttonVelcom��5,      $��10q�6+   $��1��67   ��5-      �� 5.      $$ res/velcom_logo_main_color.png��6!   50      �� 51      -   5        $ 	buttonMTS��51      $��10q�6(   $��2��64   ��52      �� 53      $ res/MTSlogo.jpg��6!   55      56      58      59      
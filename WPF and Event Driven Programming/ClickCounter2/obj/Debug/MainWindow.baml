   M S B A M L   `   `   `  ����  ClickCounter2    ClickCounter2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Click Counter��5   	   $	��350��6   $	��525��6,   .��5      � .+�5   
   �� -   5         ��Name$ btnClick��5      $��	Click Me!��6#   $
��Left=�67   $��
198,58,0,0q�6R   $	��Top=�6f   $	��105��6~   $��39��6�    � Triggers 5      :� 5       :� RoutedEvent$ Button.Click��6   .[�5	      �� .��5
      �� .��5      W�  �� 
TargetName$ lblNumClicks��5   %    �� TargetProperty$ FontSize�5   %    W� From$ 11X�6J   	 W� To$ 76X�6T    g� Duration$ 0:0:0.4D�5   %   5      5      5      5      �� 5   
   -   5        	 ��Name$	 lblNumClicks��5      $
��Left=�6*   $��198,128,0,104q�6E   $
��Wrap=�6\   
 �� TextAlignment$
 Center=�6p   $��87��6�   $	��105��6�   $��Bodoni MT Black)�6�   5      5      
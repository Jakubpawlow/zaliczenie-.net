   M S B A M L   `   `   `  ����  zadanie1    Zadanie1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5         StandardButtonBackground �� Color  LabelSpecialColor  ButtonStaticColor  ButtonHoverColor  ButtonPressedColor  BoldLabelStyle �� 
TargetType �� Property �� Value  SpecialLabelStyle �� BasedOn  StandardButtonStyle  WrapPanelButtonStyle �� Triggers P� Property	 P� Value��%�  &	        &	      &	 <     &	 Z     &	 x     &	 �     &	     7  7  &	 M    7   &	 �    7  7  7  7  �� 5   
   $
 #EEE��6;   �� 5   
   $
 #900��64   �� 5	   
   $
 #DDF��64   �� 5
   
   $
 #99D��63   �� 5   
   $
 #99F��65   �� 5   
   " ��6'   .�5      ��  � ��$
 Bold"�6+   �� 5       � ��$ 24(�6)   5      �� 5   
   " ��6*   8   .�5      ��  � ��8  6+   5      �� 5   
   " ��6,   .�5      ��  � ��8   6+   �� 5       � ��$ 20(�6)   5      �� 5   
   " ��6-   .�5       ��  � ��$ 20(�6)   �� 5!       � ��8   6+   �� 5"       � ��
 �   �6+   �� 5#       � ��8  6,    5$      P� 5%       �@J�IsMouseOver$
	 True��61   . �5&      ��  � ��8  63   5'      P� 5(       � ��$
	 True��6/   . �5)      ��  � ��8  63   5*      5,      5-      .��5/      � .+�51   
   � 
 � Orientation$
 
Horizontal=�6   $	��Top=�6-   $��10q�6E   .+�52      �� $��Button 1��6   #��[ 6(   $��5q�6V   �� 53      $��Button 2��6   #��[ 6(   $��5q�6V   �� 54      $��Button 3��6   #��[ 6(   $��5q�6V   55      �� 58   
    �� Orientation$ Vertical=�6   $
��Left=�6,   $��10q�6G   .+�59      �� $��Group 1��6   #��[ 6&   �� 5:      $��Group 2��6   #��[ 6&   �� 5;      $��Group 3��6   #��[ 6&   5<      5=      5>      
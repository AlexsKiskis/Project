   M S B A M L   `   `   `  ����@  <input, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   LmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     5   	     � Title$  Приложение��5	   	   $	��615��6   $	��405��6)    � WindowStyle$
 None=�65    � WindowStartupLocation$ CenterScreen=�6H    � 
ResizeMode$ NoResize=�6m   ��5
      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FFDA8FFF��6    � Offset$ 1Q�6-   � 5      $ 	#FFFDBB77��6   $ 0Q�6-   � 5      $ 	#FFA9FFC6��6   $
 0.36Q�6-   � 5      $ 	#FF7AE4FF��6   $
 0.69Q�6-   5       � 	Resources 5         ComboboxButton	 �� 
TargetType
 �� Property �� Value �� 
TargetType �� Triggers :� RoutedEvent �� TargetProperty g� Duration	 t� To  Tb �Name J� SnapsToDevicePixels ��Name �� CornerRadius ��Name P� Property P� Value��%q  &	        &	 �    �� 5   
   "	 ��6'   .�5      �� 
 �@�OverridesDefaultStyle . 66   �� 5      
 � �� �	#FFFFE6C16+   �� 5      
 � �� 5      �� 5      " ��6&   .R�5!      �� $��border��6!   $��0q�6/   
�������#��z��6W   ._�5#      �� $��Center=�6/   $��Center=�6L   6i   5%       5'      :� 5)      $ PreviewMouseDown��6+   .[�5+   "   �� .��5-   &   �� .��5/   *   t� $ Margin�6=   $ 	0:0:0.100D�6`   $ 2,2,0,0X�6u   51   '   53   #   55      :� 57      $ PreviewMouseUp��6+   .[�59   "   �� .��5;   &   �� .��5=   *   t� $ Margin�6=   $ 	0:0:0.100D�6`   $ 0X�6u   5?   '   5A   #   5C      5G      5K      5M      �� 5O   
   "	 ��6   .�5Q      �� 
 � �� �	#FFFFE6C16+   �� 5R      
 � ��$ Center=�69   �� 5S      
 � ��$ 35��6'   �� 5T      
 � �� �	#FF3737376+   �� 5U      
 � �� �	#FF8CF7AB6,   �� 5V      
 � ��$ 10,0,0,0q�6(   �� 5Y      
 � �� 5[      �� 5]      " ��6&   .R�5_      � $
 Root��6   #��z��6-   #��z��6O    . .+�5a      �� $ 
Background��6%   $��2q�69   $ 2��6M   #��z��6^   #��z��6�   �� 5c      $ PART_ContentHost��6+   $��0q�6E   #��z��6Y   ��.  #��z��6�   ��6�   Z� 6�   5e       5g      P� 5i       �@J�IsMouseOver . . �5k   "   �� 
 � �� �	#FFFDD7AE6?   �� 5l   "   
 � �� �	#FFB0B8FF6@   5n      P� 5p       �@J�	IsFocused . . �5r   "   �� 
 � ��
 �����6@   �� 5s   "   
 � �� �	#FFFDD7AE6?   5u      5y      5}      5�      5�      .��5�      �  � RowDefinitions 5�   
   �� 5�      $��30 �6   �� 5�      $	��200 �6   �� 5�      $	��150 �6   �� 5�      $	��135 �6   �� 5�      $	��100 �6   .+�5�   
   � -   5        $��ToolBar��5�      
������ $��0��67   .+�5�      � 
������� J� Opacity$	 0.4Q�6#    � Points) �    �����  �� �� ����� 6V   �� 5�       �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5�      �� -   5        $��	MinButton��5�      $��5,5,0,5q�6)   $��20��6:   $��20��6F   ��5�      �� 5�      "	 ��6    .�5�      �� 
 � ��$ \Resources\turnoff.jpg��67    �� Triggers 5�      �� 5�   "    �� Binding 6.   �� *IsMouseOver+ �� ElementName$ 	MinButton��  �� Value  True6e   .a�5�   &   �� 
 � ��$ \Resources\turnon.jpg��6?   5�   #   5�      5�      �� 5�      -   5        $��
ExitButton��5�      $��5,5,5,5q�6*   $��20��6;   $��25��6G   ��5�      �� 5�      "	 ��6    .�5�      �� 
 � ��$ \Resources\closeoff.jpg��67    5�      �� 5�   "    6.   �� *IsMouseOver+$ 
ExitButton��  True6f   .a�5�   &   �� 
 � ��$ \Resources\closeon.jpg��6?   5�   #   5�      5�      5�      5�      � 5�   
   -   5        $��LogoContainer��5�      
������ $��1��6=   .+�5�      �� $��heathen��6   $��Center=�6&   $��0,60,0,0q�6C   $	��Top=�6U   4  .System.Windows.Automation.AutomationProperties!   IsOffscreenBehavior$! Onscreen=�6m   $��Times New Roman)�6�   $
��Bold"�6�   $��72(�6�   $��Normal$�6�   $y�Visible=�6�   ���	#FF3737376  �� 5�      $��e n t e r t a i m e n t��6   $��Center=�66   $��	0,125,0,0q�6S   $	��Top=�6f   $��Times New Roman)�6~   $��20(�6�   $
��Bold"�6�   ���	#FF3737376�   5�      �� 5�   
   $��3��6   $��35��6   $	��180��6*   $��Center=�66   $��Center=�6S   $��	25,0,25,0q�6n   $ 2��6�   $��2q�6�   ���	#FFFF8181��5�      �� 5�      "	 ��6   .�5�      �� 
 � �� �	#FF8CF7AB64    5�      P� 5�       �@J�IsMouseOver . . �5�      �� 
 � �� �	#FFB0B8FF6<   5�      :� 5�      $ PreviewMouseDown��6'   .[�5�      �� .��5�   "   �� .��5�   &   �� $ BorderBrush.Color�65   $ 	0:0:0.100D�6c   	" �� To$" WhiteX�6x   5�   #   5�      5�      :� 5�      $ PreviewMouseUp��6'   .[�5�      �� .��5�   "   �� .��5�   &   �� $ BorderBrush.Color�65   $ 	0:0:0.100D�6c   $" 	#FFB0B8FFX�6x   5�   #   5�      5�      5�      ._�5�      �� $"��Авторизоваться��6   $��14(�6.   #��[  6<   6f   5�      �� 5�   
   -   5        # ��Name$	# tb1��5�      $��2��6   #��[ 6,   $��	25,0,25,0q�6H   $��Center=�6[   6v   �� 5�   
   $ J� IsHitTestVisible$ .  $��14(�6-   $&�� Введите ваш логин��6;   $��2��6T   $��
40,66,35,0q�6a   $	��Top=�6u   ���	#FF373737$��Normal"�6�   $��Normal$�6�   $��Times New Roman)�6�   ��5�      �� 5�      "	 ��6   .�5�      �� 
 � y�$ 	Collapsed=�63    5�      �� 5�       6&   �� *Text+$	 tb1��   6P   .a�5�      �� 
 � y�$ Visible=�6;   5�      5�      5      �� 5  
   -   5        $	# tb2��5     $��2��6   #��[ 6,   $��
25,80,25,0q�6H   $��Bottom=�6\   �� 5  
   $ .  $��14(�6-   $(��"Введите ваш пароль��6;   $��2��6U   $��40,123,35,0q�6b   $	��Top=�6w   ���	#FF373737$��Times New Roman)�6�   ��5     �� 5     "	 ��6   .�5     �� 
 � y�$ 	Collapsed=�63    5     �� 5      6&   �� *Text+$	 tb2��   6P   .a�5	     �� 
 � y�$ Visible=�6;   5
     5     5     �� 5  
   -   5        $	��Tgb��5  '   $��Запомнить��6   $��3��62   $��20��6?   $��20��6K   $
��Left=�6V   $	��Top=�6q   $��40,5,0,0q�6�   ��5     �� 5     " ��6"   .R�5     �� .+�5     �� $��20��6!   $��20��6-   $ 2��68   $
��Left=�6I   $��2q�6d   ���	#FFFFE6C1��5     �� 5  "   "	 ��6(   .�5  &   �� 
 � �� �	#FF8CF7AB6D    5  &   P� 5  *    �@J�IsMouseOver . . �5  .   �� 
 � �� �	#FFB0B8FF6L   5  +   :� 5  *   $ PreviewMouseDown��67   .[�5  .   �� .��5   2   �� .��5!  6   �� $ BorderBrush.Color�6E   $ 	0:0:0.100D�6s   $
" BlueX�6�   5"  3   5#  /   5$  +   :� 5%  *   $ PreviewMouseUp��67   .[�5&  .   �� .��5'  2   �� .��5(  6   �� $ BorderBrush.Color�6E   $ 	0:0:0.100D�6s   $" SkyBlueX�6�   5)  3   5*  /   5+  +   5-  #   ._�5/     �� ��50  "   �� 51  &    52  *   �� 53  .    6:   �� *	IsChecked+% �� RelativeSource% �� & �� AncestorType"& ��  True6�   .a�54  2   �� 
 � ��$ \Resources\stayin.png��6Q   55  /   57  '   59     5:     �� 5;     $��30,0,0,0q�6+   #��z��6=   5<     5=     5?     5A     5C     
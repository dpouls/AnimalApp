   M S B A M L   `   `   `  ����D  @AnimalApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:AnimalApp	AnimalApp  5   	       AnimalApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:AnimalApp     5   	     � Title$  
Ice Beasts��5   	   $	��450��6   $	��800��6)   $��Papyrus)�65   $��15(�6J    � WindowStartupLocation$ CenterScreen=�6X   ��5	      �� 5
   
    �� ImageSource$ snow.jpg��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��1.2* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��1.5* �6   �� 5      $
��2.5* �6   �� 5      $	��.5* �6   .+�5   
   � $��1��6    5      �� 5      $��* �6'   �� 5      $	��.5* �6'   �� 5      $��* �6'    5      �� 5      $��* �6$   �� 5       $��* �6$   �� 5!      $��* �6$   .+�5#      	� -   5         	�Name$ RBTroll��5#      $��Frost Troll��6/   $��1��6E   $��Center=�6R    � Cursor$
 Hand��6�   	� 5$      -   5        $ RBYeti��5$      $
��Yeti��6*   $��1��69   $��1��6F   $��Center=�6V   $
 Hand��6�   	� 5%      -   5        $ RBDragon��5%      $��White Dragon��6,   $��1��6C   $��2��6P   $��Center=�6`   $
 Hand��6�   5&      �� 5'   
   $��1��6   $��
Base Class��6    .��5(      �� .+�5)      �� -   5         ��Name$ BtnMove��5)      $
��Move��6*   $
��0 10q�69   $
 Hand��6]   �� 5*      -   5        $ BtnEat��5*      $	��Eat��6)   $
 Hand��6L   5+      5,      �� 5-   
   $��1��6   $��1��6    $��Derived Class��60   .��5.      �� .+�5/      �� -   5        $ BtnPet��5/      $	��Pet��6)   $
��0 10q�67   $
 Hand��6Z   �� 50      -   5        $ BtnSound��50      $��Sound��6+   $
 Hand��6R   51      52      �� 53   
   $��1��6   $��2��6    $��
Properties��60   .��54      �� .+�55      �� -   5        $ BtnFood��55      $��	Food Type��6*   $
��0 10q�6>   $
 Hand��6b   �� 56      -	   5        $ BtnSkin��56      $��	Skin Type��6*   $
 Hand��6T   57      58      �� 59   
   -
   5         ��Name$ ImgBeast��59      $��2��6"   $��1��6/   $��mammoth.jpg��6?   $��5q�6T   �� 5:   
   -   5        	 ��Name$	 
LblResults��5:      $#��Select a beast to learn more.��5;      $��3��5<      $��3��5=      $��Center=�5>      $��Center=�5?      5A      5B      
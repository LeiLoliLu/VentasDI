   M S B A M L   `   `   `  ����
  Ventas    Ventas.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��900��6   $
��1600��6)   .��5      � -   5         �Name$ MainGrid��5      .+�5   
   �� -   5         ��Name$ SplashImage��5      $$��/Images/pear_splash_screen.png��6%   $
��Fill=�6M   6\   �� 5	   
   -   5         ��Name$ 
BackButton��5	      $��← Back��6%   $y�	Collapsed=�66   $��90��6M   $��30��6X   $
��Left=�5
   	   $	��Top=�6$   $��30 60q�6<    K� ZIndex$ 1��6d      
TextButton#��[  5       � 5   
   -   5          �Name$ 	MainFrame��5      $y�	Collapsed=�6#     � NavigationUIVisibility$ Hidden=�6:     � JournalOwnership$ OwnsJournal=�6Z   �� 5   
   -   5         ��Name$ 	MenuPanel��5      	 �� Orientation$	 
Horizontal=�6(   $��Center=�6A   $��Center=�6^   $y�	Collapsed=�6y   .+�5      �� $	��300��6   $	��300��6!   
 �� CornerRadius$
 15��6.   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 5Q�6'      
BlurRadius$ 15Q�67      Opacity$	 0.5Q�6G   ._�5      �� 
������ $��0q�62   $��0q�6F     HoverButtonStyle#��[ 6R   .��5      �� $��Center=�6!   $��Center=�6>   .+�5      �� $��/Images/usericon.png��6    $	��120��6>   $	��120��6J   �� 5      $��	Employees��6$   $��28(�65   $��Center=�6C   5      5      5      �� 5       J� Opacity$ 0Q�6   $��50��6$   �� 5       $	��300��6   $	��300��6!   $
 15��6.   
������� 5!        5"      $ 5Q�6'   $ 15Q�67   $	 0.5Q�6G   ._�5$      �� -   5        
������ $��0q�5$   2   $��0q�6F   #��[ 6k   .��5%      �� $��Center=�6!   $��Center=�6>   .+�5&      �� $��/Images/articleicon.png��6    $	��120��6A   $	��120��6M   �� 5'      $��Articles��6$   $��28(�64   $��Center=�6B   5(      5)      5*      �� 5+      $ 0Q�6   $��50��6$   �� 5-      $	��300��6   $	��300��6!   $
 15��6.   
������� 5.        5/      $ 5Q�6'   $ 15Q�67   $	 0.5Q�6G   ._�51      �� 
������ $��0q�62   $��0q�6F   #��[ 6R   .��52      �� $��Center=�6!   $��Center=�6>   .+�53      �� $��/Images/salesicon.png��6    $	��120��6?   $	��120��6K   �� 54      $��Sales��6$   $��28(�61   $��Center=�6?   55      56      57      58      �� 5;   
   -   5        $ PearLogo��5;      $	 
Horizontal=�6'   $��Right=�6@   $	��Top=�6\   $��	0,10,10,0q�6t   $y�	Collapsed=�6�   .+�5<      �� $��iPear��6   $��48(�6%   $��Center=�63   �� 5=      -   5        $��/Images/pear_logo.png��5=      $��80��63   $��80��6>    � Cursor$
 Hand��6J   6X   5>      5?      5@      
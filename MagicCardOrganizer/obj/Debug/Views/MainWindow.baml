   M S B A M L   `   `   `  ����M  IMagicCardOrganizer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:MagicCardOrganizer.ViewModelsMagicCardOrganizer.ViewModels  5      #    MagicCardOrganizer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Cdatacontext+clr-namespace:MagicCardOrganizer.ViewModels     5        � Title$  
MainWindow��5      $��567.665��6"   $��536.57��63    � DataContext 5      3  -MagicCardOrganizer.ViewModels.BrowseViewModel  5   
   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��366* �6   �� 5      $	��19* �6   �� 5      $
��168* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��3��6.   $��	0,0,41,10q�6B   .+�5      �� $ Vertical=�6   .+�5      �� $
��Left=�6   $��0,0,0,0q�68   $	��Top=�6I   $	��253��6a   .+�5      �� $��Enter New Magic Card
��6   �� 5      -   5         ��Name$ EnterCardStackPanel��5   !   $��0,0,0,0q�6>   $ 
Horizontal=�6O   .+�5      �� $��Card
��6    $
��Left=�64   $��43��6O   $	��Top=�6[   $��39��6s   �� 5      -   5         ��Name$ 	EnterCard��5   "   $��34��65   $	��134��6A   $��0,0,0,0q�6M   ��6^   �� *
CardName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ 	LostFocus=�.��6�   5      5      �� 5      -   5        $ EntePowerStackPanel��5   !   $��0,0,0,0q�6>   $ 
Horizontal=�6O   .+�5      �� $��Power��6    $
��Left=�60   $��43��6K   $	��Top=�6W   $��45��6o   �� 5      -   5        $ 
EnterPower��5   "   $��34��66   $	��111��6B   $��0,0,0,0q�6N   ��6_   �� *Power+$ TwoWay=�$ 	LostFocus=�5      �� 5      -   5        $ EnteDefenseStackPanel��5   !   $��0,0,0,0q�6@   $ 
Horizontal=�6Q   .+�5      �� $��Defense��6    $
��Left=�62   $��43��6M   $	��Top=�6Y   $��53��6q   �� 5      -   5        $ EnterDefense��5   "   $��34��68   $	��111��6D   $��0,0,0,0q�6P   ��6a   �� *	Defense+$ TwoWay=�$ 	LostFocus=�5       �� 5!      -   5        $ EnteSpecialStackPanel��5!   !   $��0,0,0,0q�6@   $ 
Horizontal=�6Q   .+�5"      �� $��Special��6    $
��Left=�62   $��43��6M   $	��Top=�6Y   $��53��6q   �� 5#      -   5        $ EnterSpecial��5#   "   $��34��68   $	��111��6D   $��0,0,0,0q�6P   ��6a   �� *	Special+$ TwoWay=�$ 	LostFocus=�5$      �� 5%      -	   5         ��Name$ imgData��5&   )   $	��164��5%      $
��Left=�6)   $��	68,0,67,0q�5&      $
��Fill=�6:   $	��Top=�6I   $	��118��6a   ��5%   D   �� *Image+5&   a   �� 5'      $��
Find Image��6   	 �� 	IsDefault	 .  $��0,0,0,0q�6D   $��30��6w   ��6U   �� *LaunchFileBox+6w   5)      5*      �� 5+      $ Vertical=�6   .+�5,      �� $
��Left=�6   $��0,0,0,0q�68   $	��Top=�6I   $	��253��6a   .+�5-      �� $��View Existing Card
��6   �� 5.      $��0,0,0,0q�6!   $ 
Horizontal=�62   .+�5/      �� $��Card
��6    $
��Left=�64   $��43��6O   $	��Top=�6[   $��39��6s   �� 50      $��Visible=�6"   $��20��6U   .@�51      �� .��6*   ListBox Item #16;   �� 52      .��6*   ListBox Item #26;   �� 53      .��6*   ListBox Item #36;   54      55      57      5:      5;      �� 5<   
   
���   �$��1q�6%   $
��Left=�69   $	��562��6T   $	��Top=�6a   $	��253��6y   $��	0,-26,0,0q�6�   
 � ContextMenu
 6�   �� *LaunchCardName+$ Default=�._�5=      �� $��Create Card��6   	 . $��31,442,27,94q�6<   ��6R   �� *LaunchCardName+5>      �� 5@   
   
���   �$��1q�6%   $
��Left=�69   $	��536��6T   $	��Top=�6a   $	��275��6y   $��	253,0,0,0q�6�   $��3��6�   5C      5D      
   M S B A M L   `   `   `  ����C  ?Pets_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Pets_AppPets_App  5   	       Pets_App.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Pets_App     5   	   -   5          �Name$  
mainWindow��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ 
MainWindow��5	   	   $
��1040��6   $
��1200��6*   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ btn_SaveName��5      $��	Save Name��6'   $
��Left=�6;   $��297,258,0,0q�6V   $	��Top=�6k   $	��225��6�   $��43��6�   �� 5   
   -   5         ��Name$ AvailablePets_listbox��5      $
��Left=�61   $	��686��6L   $��
18,200,0,0q�6Y   $	��Top=�6m   $	��238��6�   �� 5   
   -   5         ��Name$ lbl_dogList��5      $��Available Pets��6%   $
��Left=�6>   $��
18,169,0,0q�6Y   $	��Top=�6m   $	��103��6�   $��26��6�   �� 5   
   -   5        $ 
lbl_Titile��5      $!��Castle Hill Gaming Pets App��6$   $
��Left=�6J   $��
219,46,0,0q�6e   $	��Top=�6y   $��Showcard Gothic)�6�   $��50(�6�   $��72��6�   $	��737��6�   �� 5   
   -   5        $ UserPetsListbox��5      $
��Left=�6+   $	��341��6F   $��297,545,0,0q�6S   $	��Top=�6h   $	��225��6�   �� 5   
   -   5        $ lbl_userList��5      $��My Pets��6&   $
��Left=�68   $��297,512,0,0q�6S   $	��Top=�6h   $	��103��6�   $��33��6�   �� 5   
   -   5         ��Name$ txt_petName��5      $
��Left=�6'   $��42��6B   $��297,200,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��225��6�   $y�Visible=�6�   �� 5   
   -	   5        $ btn_Confirm��5      $��Confirm��6&   $
��Left=�68   $��297,446,0,0q�6S   $	��Top=�6h   $	��225��6�   $��61��6�   6�   �� 5   
   -
   5        $ lbl_petName��5      $��Pet Name��6%   $
��Left=�68   $��297,169,0,0q�6S   $	��Top=�6h   $	��225��6�   $y�Visible=�6�   $��26��6�   �� 5   
   -   5        	 ��Name$	 comboBox_available_food��5      $
��Left=�64   $��760,259,0,0q�6O   $	��Top=�6d   $	��163��6|   $y�Hidden=�6�   $��25��6�   .@�5      �� $��Bacon Snack��6   �� 5      $��Dry Dog Food��6   �� 5      $
��Tuna��6   �� 5      $��Dry Cat Food��6   �� 5      $��	Fish Food��6   5      �� 5   
   -   5        $ lbl_available_food��5      $!��Choose food to feed you pet��6,   $
��Left=�6R   $��760,223,0,0q�6m   $	��Top=�6�   $y�Hidden=�6�   $��30��6�   $	��163��6�   �� 5    
   -   5        $ btn_start_feed_pet��5       $��Start Feeding��6-   $
��Left=�6E   $��604,223,0,0q�6`   $	��Top=�6u   $	��103��6�   $��61��6�   6�   �� 5!   
   -   5        $ btn_Feed��5!      $
��Feed��6#   $
��Left=�62   $��989,223,0,0q�6M   $	��Top=�6b   $	��103��6z   $��61��6�   6�   �� 5"   
   -   5        $ btn_start_interacting_pet��5"      $��Start Interacting��64   $
��Left=�6P   $��604,446,0,0q�6k   $	��Top=�6�   $	��103��6�   $��61��6�   6�   �� 5#   
   -   5        $$	 comboBox_available_Interaction��5#      $
��Left=�6;   $��760,482,0,0q�6V   $	��Top=�6k   $	��163��6�   $y�Hidden=�6�   $��25��6�   .@�5$      �� $	��Pet��6   �� 5%      $��	Rub Belly��6   �� 5&      $
��Play��6   �� 5'      $��Ignore��6   �� 5(      $��Scold��6   �� 5)      $��
Play Music��6   �� 5*      $��Talk To Them��6   �� 5+      $��Tap On Glass��6   5,      �� 5-   
   -   5        $ lbl_available_Interaction��5-      $��Pick an interaction��63   $
��Left=�6Q   $��760,443,0,0q�6l   $	��Top=�6�   $y�Hidden=�6�   $��30��6�   $	��163��6�   �� 5.   
   -   5        $ btn_Interact��5.      $��Interact��6'   $
��Left=�6:   $��989,446,0,0q�6U   $	��Top=�6j   $	��103��6�   $��61��6�   6�   �� 5/   
   -   5        $ btn_current_state��5/      $��Check Pet Info��6,   $
��Left=�6E   $��604,902,0,0q�6`   $	��Top=�6u   $	��261��6�   $��61��6�   6�   �� 50   
   -   5        $ lbl_happiness_status��50      $��Happiness Level : ��6.   $
��Left=�6K   $��621,754,0,0q�6f   $	��Top=�6{   $	��110��6�   �� 51   
   -   5        $ lbl_hungerness_status��51      $��Hunger Level : ��6/   $
��Left=�6I   $��621,807,0,0q�6d   $	��Top=�6y   $	��105��6�   
 J� RenderTransformOrigin$
 0.5,0.5&�6�   �� 52   
   -   5        $  lbl_happiness_status_VALUE��52      $�� ��64   $
��Left=�6?   $��763,754,0,0q�6Z   $	��Top=�6o   $	��111��6�   �� 53   
   -   5        $! lbl_hungerness_status_VALUE��53      $�� ��65   $
��Left=�6@   $��763,807,0,0q�6[   $	��Top=�6p   $
 0.537,1.333&�6�   $	��111��6�   �� 54   
   -   5        $ lbl_selected_pet_name��54      $��Selected Pet Name : ��6/   $
��Left=�6N   $��621,696,0,0q�6i   $	��Top=�6~   �� 55   
   -   5        $! lbl_selected_pet_name_VALUE��55      $�� ��65   $
��Left=�6@   $��763,704,0,0q�6[   $	��Top=�6p   $	��111��6�   �� 56   
   
���   �$��1q�6%   $
��Left=�69   $	��206��6T   $��604,680,0,0q�6a   $	��Top=�6v   $	��261��6�   �� 57   
   -   5        $ 
btn_remove��57      $��
Delete Pet��6%   $
��Left=�6:   $��297,902,0,0q�6U   $	��Top=�6j   $	��225��6�   $��61��6�   6�   �� 58   
   -   5        $ lbl_AuthorName��58      $#��Developed by : Ahmed Metwoali��6(   $
��Left=�6P   $��943,971,0,0q�6k   $	��Top=�6�   $
��Bold"�6�   $��15(�6�   �� 59   
   -   5        $ txt_response��59      $
��Left=�6(   $��44��6C   $��604,545,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��488��6�    �� 
IsReadOnly . 6�   5:      5;      
   M S B A M L   `   `   `  ���� D  @Snake2Arc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Snake2Arc	Snake2Arc  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel     Snake2Arc.GameWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:Snake2Arc     Hscm8clr-namespace:System.ComponentModel;assembly=WindowsBase     -     �Name$  
MainWindow�� � Title$ 	Snake2Arc�� � WindowStyle$ SingleBorderWindow=����#272928 � 	Resources    LeaderBoardListSource �� Source �� ElementName �� Path �� SortDescriptions+  %System.ComponentModel.SortDescription   	Direction	   PropertyName��%j   &	        ��  �� $ 
MainWindow��$ LeaderBoardList�   $ 
Descending=�$	 
ScoreValue��.��(� -   
 (�Name$
 mainViewBox��$
��1080��$
��1920��.��� $��Center=�$��Center=� � RowDefinitions �� $��* ��� $
��auto � � ColumnDefinitions �� $��* �.+�� $��0��$��0�� � Orientation$ 
Horizontal=�$��Center=�.+��� -   $��
scoreBoard��
�������$��50(�$��	Snake2Arc��(� -   $
 viewBoxCanvas��$��1��$��0��.���� -   $��paintCanvas��
���   �$��1��$��Stretch=�$��Bottom=�$	��450��$	��550��.+��� -   $��mainMenu��
�������$��2q�$	��250��$	��170�� �� Left$	 150��
 �� Top$	 100�� K� ZIndex$ 2��._���  �� Orientation$ Vertical=�
�������.+��� -   $��5q�$��2q����	#FF8A2BE2$��	Play Solo���� -   $��5q�$��2q����	#FF8A2BE2$��Play Double���� -	   $��5q�$��2q����	#FF8A2BE2$��LeaderBoard���� -
   $��5q�$��2q����	#FF8A2BE2$��Options���� -   $��5q�$��2q����	#FF8A2BE2$
��Quit���� -   $��leaderBoard��
�������$��2q�$	��250��$	��285��$	 150��$	 100��$ 2��$y�	Collapsed=�._��� $ Vertical=�
�������.+��� $��Center=�$��30(�$
��Bold"�$��Leaderboard���� ����  �� Source# [  ���� .R�]� $��7q�.+��� $
��Left=�$��20(����� *Name+�� $��Right=�$��20(�$��Right=����� *
ScoreValue+�� -   $��4q�$��2q����	#FF8A2BE2$��Return to main menu���� -   $��addNewScore��
�������$��2q�$	��250��$	��200��$	 150��$	 100��$ 2��$y�	Collapsed=�._��� $ Vertical=�
�������.+��� $��Center=�$��20(�$
��Bold"�$��15q�$
��Wrap=�$)��#You are one of the 5 best scorers !���� -   $��playerNameAdded��$��Center=�$��20(� �� 	MaxLength$ 25��$��20q��� -   $��button_add_new_score��$��Center=�$��20(�$��5q����	#FF8A2BE2$��Add your score���� -   $��gameOver1Player��
�������$��2q�$	��250��$	��150��$	 200��$	 100��$ 2��$y�	Collapsed=�._��� $ Vertical=�
�������.+��� $��20q� �� TextAlignment$ Center=�$��16(�$��GAME OVER, Your score:��$
��Wrap=��� -   $��scoreWin1Player��$ Center=�$��36(�
���  ��$��0���� -   $��4q�$��2q����	#FF8A2BE2$��Return to main menu���� -   $��gameOver2Player��
�������$��2q�$	��250��$	��125��$	 150��$	 100��$ 2��$y�	Collapsed=�._��� $ Vertical=�
�������.+��� -   $��whoLose2Player��$��20q�$ Center=�$��16(�$��GAME OVER, Player ��$
��Wrap=��� -   $��4q�$��2q����	#FF8A2BE2$��Return to main menu���� -   $��	pauseMenu��
�������$��2q�$	��250��$	��200��$	 150��$	 100��$ 2��$y�	Collapsed=�._��� $ Vertical=�
�������.+��� $��20q�$ Center=�$��16(�$��Game Paused���� -   $��4q�$��2q����	#FF8A2BE2$��Resume���� -   $��4q�$��2q����	#FF8A2BE2$��Leave���� -   $��
optionMenu��
�������$��2q�$	��250��$	��200��$	 150��$	 100��$ 2��$y�	Collapsed=�._��� $ Vertical=�
�������.+��� $��20q�$ Center=�$��16(� �� Padding$ 2q�$��Option���� $��20q�$ Center=�$��12(�$%��Easy - Medium - Hard - Hardcore���� -   $��thickSlider�� � Maximum$ 20Q� � Minimum$ 5Q� �� IsSnapToTickEnabled .  �� TickFrequency$ 5Q� � Value$ 10Q��� -   $��
checkMusic��$��Center=� d� 	IsChecked$
 TrueY�$y�Visible=�.��Music�� -   $��4q�$��2q����	#FF8A2BE2$��Back to Main��
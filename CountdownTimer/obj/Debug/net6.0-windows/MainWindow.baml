   M S B A M L   `   `   `  ����I  ECountdownTimer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CountdownTimerCountdownTimer  5   	       CountdownTimer.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:CountdownTimer     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � .+�5   
   �� -   5         ��Name$ CountdownDisplay��5      $
��Left=�6.   $��
412,88,0,0q�6I   $
��Wrap=�6]   $
��40px(�6q   $�� ��6�   $	��Top=�6�   $��63��6�   $��61��6�   �� 5   
   -   5         ��Name$ CountdownInputTextBox��5      $
��Left=�61   $��354,161,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��159��6�   $��23��6�   �� 5   
   -   5         ��Name$ StartButton��5      ���#218838$��Start��6;   $
��Left=�6K   $��268,245,0,0q�6f   $	��Top=�6{   $��35��6�   $��98��6�   6�   �� 5   
   -   5        $ 
StopButton��5      ���#ee293c$
��Stop��6:   $
��Left=�6I   $��412,245,0,0q�6d   $	��Top=�6y   $��35��6�   $	��101��6�   6�   �� 5   
   -   5        $ ResetButton��5      $��Reset��6&   ���#f3a867$
��Left=�6K   $��354,380,0,0q�6f   $	��Top=�6{   $��29��6�   $��72��6�   6�   �� 5   
   -   5        $ PauseButton��5      ���#ffd000$��Pause��6;   $
��Left=�6K   $��268,316,0,0q�6f   $	��Top=�6{   $��98��6�   $��32��6�   6�   �� 5   
   -   5        $ ContinueButton��5      $��Continue��6)   ���#17a5bc$
��Left=�6Q   $��412,317,0,0q�6l   $	��Top=�6�   $��31��6�   $	��101��6�   6�   �� 5   
   $��Input Time(seconds)��6   $
��Left=�6.   $��232,158,0,0q�6I   $	��Top=�6^   �� 5   
   $��S��6   $
��40px(�6   $
��Left=�6,   $��
482,83,0,0q�6G   $	��Top=�6[    J� RenderTransformOrigin$ 1.097,0.518&�6s   5      5      
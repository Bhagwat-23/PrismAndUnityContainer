   M S B A M L   `   `   `  ����N  JProject.CommonInfra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullbDclr-namespace:Project.CommonInfra.Views;assembly=Project.CommonInfraProject.CommonInfra.Views  5       Project.MainArea&    Project.MainArea.Views.TestView1   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      P LPrism.Wpf, Version=6.3.0.0, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59)prismhttp://www.codeplex.com/prism  5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      OviewDclr-namespace:Project.CommonInfra.Views;assembly=Project.CommonInfra  5      $
��Auto��5
      $
��Auto��6   .  (System.Windows.Interactivity.Interaction    Triggers  5      F  @Prism.Interactivity.InteractionRequest.InteractionRequestTrigger  5   
   3  -System.Windows.Interactivity.EventTriggerBase   SourceObject 6*   �� *PopupNotificationRequest+ �� Mode$ OneWay=�.  (System.Windows.Interactivity.TriggerBase   Actions. 5      +  %Prism.Interactivity.PopupWindowAction  !   CenterOverAssociatedObject .    IsModal .    WindowContent 5      /   )Project.CommonInfra.Views.CustomPopupView  5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��40 �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �� $��0��6   $��Test View 1��6   $��Center=�63   $��Center=�6P   �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5       �� $$��Received Data from Test View 3��6   $
��Auto��6=   $
��Left=�6J   $��Center=�6e   $��Center=�6�   �� 5!      {�.  $	��300��6R   $��Center=�6a   $��Center=�6|   ��6(   �� *ReceivedData+$ TwoWay=�6|   5"      �� 5#   
   $��2��6   $��50(�6   $
��Bold"�6+   
����  �$#��This is Test View 1 Work Area��6O   $��Center=�5$      $��Center=�6-   �� 5%   
   $��3��6   $��Right=�6   $��30��6:   $	��120��6F   $��
Click Here��6R   ��5&      �� *ClickHereCommand+5'      5(      
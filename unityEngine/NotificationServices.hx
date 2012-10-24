package unityEngine;
@:native("UnityEngine.NotificationServices") extern class NotificationServices {
	static var localNotificationCount:Int;
	static var localNotifications:unityEngine.Array<LocalNotification>;
	static var scheduledLocalNotifications:unityEngine.Array<LocalNotification>;
	static var remoteNotificationCount:Int;
	static var remoteNotifications:unityEngine.Array<RemoteNotification>;
	static var enabledRemoteNotificationTypes:unityEngine.RemoteNotificationType;
	static var deviceToken:unityEngine.Array<byte>;
	static var registrationError:String;
	function GetLocalNotification(index:Int):unityEngine.LocalNotification;
	function ScheduleLocalNotification(notification:unityEngine.LocalNotification):Void;
	function PresentLocalNotificationNow(notification:unityEngine.LocalNotification):Void;
	function CancelLocalNotification(notification:unityEngine.LocalNotification):Void;
	function CancelAllLocalNotifications():Void;
	function GetRemoteNotification(index:Int):unityEngine.RemoteNotification;
	function ClearLocalNotifications():Void;
	function ClearRemoteNotifications():Void;
	function RegisterForRemoteNotificationTypes(notificationTypes:unityEngine.RemoteNotificationType):Void;
	function UnregisterForRemoteNotifications():Void;
}
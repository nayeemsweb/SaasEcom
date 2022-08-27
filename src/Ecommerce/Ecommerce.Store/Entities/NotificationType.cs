namespace Ecommerce.Store.Entities
{
    public enum NotificationType
    {
		UserRegistration,
		StoreRegistrationNotificationToSuperAdmin,
		AccountEmailConfirmationNotification,
		ReStockNotification,
		ProductOutOfStockNotification,
		NewOrderNotificationToAdmin,
		NewOrderNotificationToCustomer,
		PaymentDueNotification
	}
}

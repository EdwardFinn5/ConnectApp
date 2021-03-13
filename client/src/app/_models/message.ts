export interface Message {
  id: number;
  senderId: number;
  senderUsername: string;
  senderFirstName: string;
  senderCompany: string;
  senderAppUserType: string;
  studentSenderUrl: string;
  companySenderUrl: string;
  recipientId: number;
  recipientUsername: string;
  recipientFirstName: string;
  recipientCompany: string;
  recipientAppUserType: string;
  studentRecipientUrl: string;
  companyRecipientUrl: string;
  content: string;
  dateRead?: Date;
  messageSent: Date;
}

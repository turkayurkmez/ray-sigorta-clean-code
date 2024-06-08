// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");
/*
 * Büyük sistemler, küçük sistemlere bağlı olmamalı
 * Küçük sistemler; bir yapı aracılığıyla büyük sisteme aktarılmalı
 * 
 */

WhatsAppSender whatsAppSender = new WhatsAppSender();
TelegramSender telegramSender = new TelegramSender();
MailSender mailSender = new MailSender();

ReportGenerator reportGenerator = new ReportGenerator(whatsAppSender);
reportGenerator.Send("patron");
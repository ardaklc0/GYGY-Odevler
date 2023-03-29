using LiskovPrinciple;

SavingAccounts AKBANK_SAVING_ACCOUNT = new() { Id = 1, AccountName = "Akbank Vadeli Hesap", AccountAmount = 6783.12, OwnerName = "Arda Kılıç" };
DepositAccounts AKBANK_DEPOSIT_ACCOUNT = new() { Id = 2, AccountName = "Akbank Yatırım Hesabı", AccountAmount = 19232.42, OwnerName = "Arda Kılıç" };

AKBANK_SAVING_ACCOUNT.DepositMoney(2342);
AKBANK_SAVING_ACCOUNT.WithDrawMoney(345);

AKBANK_DEPOSIT_ACCOUNT.DepositMoney(2342);
AKBANK_DEPOSIT_ACCOUNT.WithDrawMoney(345);
AKBANK_DEPOSIT_ACCOUNT.GetExpireDate();
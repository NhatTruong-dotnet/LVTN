export const formatCurrency = value => {
    if (value === 0) return '0 VND'
    if (!value) return
    return (+value).toLocaleString('it-IT', {
        style: 'currency',
        currency: 'VND',
    })
}

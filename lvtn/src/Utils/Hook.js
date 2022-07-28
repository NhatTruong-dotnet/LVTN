import { useEffect, useRef } from 'react'

export const useDebounceCallback = (delay = 0, cleaning = true) => {
    const ref = useRef()
    useEffect(() => {
        if (cleaning) {
            return () => {
                if (ref.current) clearTimeout(ref.current)
            }
        }
    }, [])

    return callback => {
        if (ref.current) clearTimeout(ref.current)
        ref.current = setTimeout(callback, delay)
    }
}
